using NAudio.Midi;
using Synth.Keyboard.Utils;

namespace Synth.Keyboard;

public enum NoteState { Off, On }
public class Midi {
    private readonly MidiIn? MidiIn;

    internal event EventHandler<NoteChangedEventArgs>? NoteChanged;
    public event EventHandler<MidiWheelEventArgs>? PitchWheelChanged;
    public event EventHandler<MidiWheelEventArgs>? ModWheelChanged;
    public event EventHandler<MidiControllerEventArgs>? ControllerValueChanged;

    // Convert to singleton so everything can share midi
    private static readonly Lazy<Midi> lazy =
        new(() => new Midi());

    public static Midi Instance { get { return lazy.Value; } }

    private Midi() {
        if (MidiIn.NumberOfDevices > 0) {
            MidiIn = new MidiIn(0);
            MidiIn.MessageReceived += MidiMessage;
            MidiIn.ErrorReceived += ErrorReceived;
            MidiIn.Start();
        }
    }

    private void ErrorReceived(object? sender, MidiInMessageEventArgs e) {
        // DO NOTHING!
    }

    void MidiMessage(object? sender, MidiInMessageEventArgs e) {
        switch (e.MidiEvent.CommandCode) {
            case MidiCommandCode.NoteOn:
            case MidiCommandCode.NoteOff:
                var note = Note.GetByMidiNoteNumber(((NoteEvent)e.MidiEvent).NoteNumber);
                var state = e.MidiEvent.CommandCode == MidiCommandCode.NoteOn ? NoteState.On : NoteState.Off;
                NoteChanged?.Invoke(this, new NoteChangedEventArgs(e.MidiEvent.Channel, note, state, ((NoteEvent)e.MidiEvent).Velocity));
                break;

            case MidiCommandCode.PitchWheelChange:
                var p = (PitchWheelChangeEvent)e.MidiEvent;

                PitchWheelChanged?.Invoke(this, new MidiWheelEventArgs(e.MidiEvent.Channel, p.Pitch));
                break;

            case MidiCommandCode.ControlChange:
                var c = (ControlChangeEvent)e.MidiEvent;

                if (c.Controller == MidiController.Modulation) {
                    ModWheelChanged?.Invoke(this, new MidiWheelEventArgs(e.MidiEvent.Channel, c.ControllerValue));
                    ControllerValueChanged?.Invoke(this, new MidiControllerEventArgs(e.MidiEvent.Channel, (int)c.Controller, c.ControllerValue));
                } else {
                    ControllerValueChanged?.Invoke(this, new MidiControllerEventArgs(e.MidiEvent.Channel, (int)c.Controller, c.ControllerValue));
                }
                break;
        }
    }
}

public class MidiControllerEventArgs {
    public MidiControllerEventArgs(int MidiChannel, int ControllerID, int Value) {
        this.MidiChannel = MidiChannel;
        this.ControllerID = ControllerID;
        this.Value = Value;
    }

    public int MidiChannel;
    public int ControllerID;
    public int Value;
}

public class MidiWheelEventArgs {
    public MidiWheelEventArgs(int MidiChannel, int Value) {
        this.MidiChannel = MidiChannel;
        this.Value = Value;
    }

    public int MidiChannel;
    public int Value;
}

internal class NoteChangedEventArgs {

    public int MidiChannel;
    internal Note Note;
    public NoteState State;
    public int Velocity;

    internal NoteChangedEventArgs(int MidiChannel, Note Note, NoteState State, int Velocity) {
        this.MidiChannel = MidiChannel;
        this.Note = Note;
        this.State = State;
        this.Velocity = Velocity;
    }
}

