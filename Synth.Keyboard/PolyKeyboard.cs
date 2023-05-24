using Synth.Keyboard.Utils;
using System.Text;

namespace Synth.Keyboard;

public class PolyKeyboard {
    public event EventHandler<EventArgs<string>>? DebugEvent;
    public event EventHandler<EventArgs<(int, bool)>>? KeyChanged;          // Return tuple - key number, state

    private readonly Midi midi = Midi.Instance;
    private int? _midichannel;
    public List<Key> keys;

    public PolyKeyboard(int NumVoices) {
        keys = new List<Key>(NumVoices);
        for (int i = 0; i < NumVoices; i++) {
            keys.Add(new Key() { MonoKeyboard = new MonoKeyboard() { ID = i } });
        }

        midi.NoteChanged += Midi_NoteChanged;
    }

    public int? MidiChannel {
        get { return _midichannel; }
        set {
            if (value < 1 || value > 16)
                throw new ArgumentOutOfRangeException("Midi Channel must be 1-16, or left as NULL");
            _midichannel = value;
        }
    }

    #region Note Changed Handler
    private void Midi_NoteChanged(object? sender, NoteChangedEventArgs e) {
        ProcessNote(e);
    }

    void ProcessNote(NoteChangedEventArgs e) {
        if (MidiChannel != e.MidiChannel && MidiChannel != null)                    // Midi Channel Filter
            return;

        Key? key;

        key = keys.Find(x => x.MonoKeyboard.Note.ID == e.Note.ID);                  // 1. Find if any keys is already set to this note

        if (key == null & e.State == NoteState.On)                                  // 2. If note on, we need to find oldest key that's off, then oldest key that's on
            key = keys
                .OrderBy(k => k.MonoKeyboard.NoteState)
                .ThenBy(k => k.TimeChanged).FirstOrDefault();

        // *** If we are using existing key, retrigger it so envelope restarts ***


        if (key != null) {
            key.MonoKeyboard.NoteState = e.State;
            key.MonoKeyboard.Note = Note.GetByID(e.Note.ID);
            key.TimeChanged = Timestamp();


            // Raise event to notify client of key change
            if (KeyChanged != null) {
                for (int i = 0; i < keys.Count; i++) {
                    if (keys[i] == key) {
                        KeyChanged?.Invoke(this, new EventArgs<(int, bool)>((i, e.State == NoteState.On)));
                        break;
                    }
                }
            }
        }

        RaiseDebugEvent();
    }

    void RaiseDebugEvent() {
        // Raise a debug event to show what's going on
        if (DebugEvent != null) {
            // Dump string version of keys to be printed out by client
            StringBuilder s = new ();
            int i = 0;
            foreach (var k in keys) {
                s.Append($"Keyboard {i.ToString()}, Note: {k.MonoKeyboard.Note.Desc.Replace("♯", "#").Replace("♭", "b"), -6}, State: {k.MonoKeyboard.NoteState.ToString(),-3}, TimeStamp: {k.TimeChanged.ToString()}\r\n");
                i++;
            }
            DebugEvent?.Invoke(this, new EventArgs<string>($"{s}\r\n"));
        }
    }

    // Rather than use expensive DateTime type, use an integral counter to serve as an ordinal timestamp
    private long _timestamp = 0;
    private long Timestamp() {
        _timestamp++;
        return _timestamp;
    }
    #endregion
}

public class Key {
    //private Note Note;
    public MonoKeyboard MonoKeyboard = new ();
    internal long TimeChanged = 0;      // Use this as a low cost time stamp where lower value is older, save expense of time/date type
}