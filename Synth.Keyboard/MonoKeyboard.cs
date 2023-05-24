using Synth.Keyboard.Utils;

namespace Synth.Keyboard;

// Keyboard and Frequency classes should be dealing with logarithmic digital
// equivalent of CV, however we've already gone down frequency route

public class MonoKeyboard : iModule {
    #region Public Events
    public event EventHandler? TriggerOn;
    public event EventHandler? TriggerOff;
    #endregion

    #region Private Variables
    // Used to implement Glide
    double _previousNoteFreq = 0;  // Previous Note       
    double _newNoteFreq;           // New Note 
    #endregion

    private NoteState _noteState = NoteState.Off;
    public NoteState NoteState {
        get {
            return _noteState;
        }

        set {
            _noteState = value;
            if (_noteState == NoteState.On)
                TriggerOn?.Invoke(this, new EventArgs());
            else
                TriggerOff?.Invoke(this, new EventArgs());
        }
    }

    #region Constructor
    public MonoKeyboard() {
        // init
        Value = Note.GetByDesc("C3").Frequency;     // Set default
        _previousNoteFreq = Value;
        _newNoteFreq = Value;
    }

    #endregion

    #region Public Properties
    public int ID;
    public double Glide { get; set; } = 0;

    private Note _Note = new ();
    internal Note Note {
        get { return _Note; }
        set {
            _Note = value;
            _newNoteFreq = _Note.Frequency;
        }
    }
    #endregion

    #region iModule Members
    public double Value { get; internal set; } = 0;

    // Main task in Tick is to implement Glide
    public void Tick(double interval) {
        // Shortcut, go straight to new note if glide is off
        if (Glide == 0) {
            Value = _newNoteFreq;
            return;
        }

        if (_previousNoteFreq != _newNoteFreq) {
            if (_previousNoteFreq < _newNoteFreq) {
                _previousNoteFreq += 1f / Glide;
                if (_previousNoteFreq > _newNoteFreq)       // Deals with overshoot !
                    _newNoteFreq = _previousNoteFreq;
            } else {
                _previousNoteFreq -= 1f / Glide;
                if (_previousNoteFreq < _newNoteFreq)
                    _newNoteFreq = _previousNoteFreq;       // Deals with undershoot !

            }
            Value = _previousNoteFreq;
        } else
            _previousNoteFreq = _newNoteFreq;
    }
    #endregion
}
