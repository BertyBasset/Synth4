using Synth.Modules.Sources.Generators;

namespace Synth.Properties;

public enum VCOWaveformType {
    Sine = 0,
    Saw,
    Triangle,
    Square,
    SuperSaw,
    SawFalling
}

public class VCOWaveForm {
    #region Public Properties
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public VCOWaveformType Type { get; set; }


    internal iGenerator? _Generator;
    internal iGenerator Generator {
        get {
            _Generator ??= Type switch {
                    VCOWaveformType.Sine => new GeneratorSine(),
                    VCOWaveformType.Saw => new GeneratorSaw(),
                    VCOWaveformType.Triangle => new GeneratorTriangle(),
                    VCOWaveformType.Square => new GeneratorSquare(),
                    VCOWaveformType.SuperSaw => new GeneratorSuperSaw(),
                    VCOWaveformType.SawFalling => new GeneratorSaw(),
                    // No generator for Sample and Hold. LFO will take care of it.
                    _ => new GeneratorSine(),
                };

            return _Generator;
        }
    }
    #endregion

    #region Public Methods
    public static VCOWaveForm GetByID(int ID) {
        return GetWaveFormList().Where(w => w.ID == ID).First();
    }

    public static VCOWaveForm GetByType(VCOWaveformType Type) {
        return GetWaveFormList().Where(w => w.Type == Type).First();
    }

    public static VCOWaveForm GetByName(string Name) {
        return GetWaveFormList().Where(w => w.Name.ToLower() == Name.ToLower()).First();
    }

    public static List<VCOWaveForm> GetWaveFormList() {
        List<VCOWaveForm> waveforms = new() {
            new VCOWaveForm() { ID = 0, Name = "Sine", Type = VCOWaveformType.Sine },
            new VCOWaveForm() { ID = 1, Name = "Saw", Type = VCOWaveformType.Saw },
            new VCOWaveForm() { ID = 2, Name = "Triangle", Type = VCOWaveformType.Triangle },
            new VCOWaveForm() { ID = 3, Name = "Square", Type = VCOWaveformType.Square },
            new VCOWaveForm() { ID = 4, Name = "SuperSaw", Type = VCOWaveformType.SuperSaw },
            new VCOWaveForm() { ID = 5, Name = "SawFalling", Type = VCOWaveformType.Saw }
        };

        return waveforms;
    }
    #endregion
}



public enum LFOWaveformType {
    Sine = 0,
    Saw,
    SawFalling,
    Triangle,
    Square,
    SH
}

public class LFOWaveForm {
    #region Public Properties
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public LFOWaveformType Type { get; set; }


    internal iGenerator? _Generator;
    internal iGenerator Generator {
        get {
            _Generator ??= Type switch {
                    LFOWaveformType.Sine => new GeneratorSine(),
                    LFOWaveformType.Saw => new GeneratorSaw(),
                    LFOWaveformType.Triangle => new GeneratorTriangle(),
                    LFOWaveformType.Square => new GeneratorSquare(),
                    LFOWaveformType.SawFalling => new GeneratorSaw(),
                    // No generator for Sample and Hold. LFO will take care of it.
                    _ => new GeneratorSine(),
                };

            return _Generator;
        }
    }
    #endregion

    #region Public Methods
    public static LFOWaveForm GetByID(int ID) {
        return GetWaveFormList().Where(w => w.ID == ID).First();
    }

    public static LFOWaveForm GetByType(LFOWaveformType Type) {
        return GetWaveFormList().Where(w => w.Type == Type).First();
    }

    public static LFOWaveForm GetByName(string Name) {
        return GetWaveFormList().Where(w => w.Name.ToLower() == Name.ToLower()).First();
    }

    public static List<LFOWaveForm> GetWaveFormList() {
        var waveforms = new List<LFOWaveForm> {
            new LFOWaveForm() { ID = 0, Name = "Sine", Type = LFOWaveformType.Sine },
            new LFOWaveForm() { ID = 1, Name = "Saw", Type = LFOWaveformType.Saw },
            new LFOWaveForm() { ID = 2, Name = "Saw-Falling", Type = LFOWaveformType.SawFalling },
            new LFOWaveForm() { ID = 3, Name = "Triangle", Type = LFOWaveformType.Triangle },
            new LFOWaveForm() { ID = 4, Name = "Square", Type = LFOWaveformType.Square },
            new LFOWaveForm() { ID = 5, Name = "Sample and Hold", Type = LFOWaveformType.SH }
        };

        return waveforms;
    }
    #endregion
}

