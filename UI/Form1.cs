namespace UI;
using Synth;
using Synth.Keyboard;
using Synth.Properties;
using UI.Code;
using UI.Controls;
using static Synth.Enums;


// Version 4
// Mod Wheel of in Knob Group Mode
// 1 WPF ?????
// 2 Modulation System - Matrix ?


public partial class frmMidiController : Form {
    #region Private Objects
    readonly List<Led> leds;
    readonly Synth.Patch patch = new();
    List<ControlKnobMap> _controlMapping;
    bool formLoaded = false;
    #endregion

    #region Initiallise
    public frmMidiController() {
        InitializeComponent();
        InitEventHandlers();
        InitPatch();
        InitKnobGroups();

        // This contains controller id to knob name mapping
        _controlMapping = Json<List<ControlKnobMap>>.Load(Constants.MIDI_TO_KNOB_MAPPING_FILE);

        leds = new() { ledVCO1, ledVCO2, ledVCO3, ledMixer, ledBitCrush, ledEnv1, ledEnv2, ledEnv3, ledEnv4, ledLFO, ledVCF, ledVcas, ledEffects };

    }
    #endregion

    #region Patches
    private void InitPatch() {

        if (!Persist.Exists("_autosave.json"))
            this.Controls.OfType<Knob>().ToList().ForEach(knob => knob.Value = knob.Value);
        else {
            LoadPatch("_autosave.json");
        }

        cboMidiChannel.SelectedIndex = 0;
    }

    private void LoadPatch(string FileName) {
        var knobSerialisers = Persist.Load<KnobSerialiser>(FileName);
        this.Controls.OfType<Knob>().ToList().ForEach(knob => knob.Value = knobSerialisers.First(k => k.Name == knob.Name).Value);
    }

    private void SaveCurrentPatch() {
        var knobSerialisers = this.Controls.OfType<Knob>()
            .Select(knob => new KnobSerialiser { Name = knob.Name, Value = knob.Value })
            .ToList();
        Persist.Save(knobSerialisers, "_autosave.json");
    }

    public class KnobSerialiser {
        public string Name { get; set; } = "";
        public double Value { get; set; }
    }
    #endregion

    #region Event Handlers
    private void InitEventHandlers() {
        this.Activated += (o, e) => { formLoaded = true; FilterTypeChanged(); EffectTypeChanged(); };
        this.FormClosing += (o, e) => SaveCurrentPatch();
        cmdInit.Click += (o, e) => LoadPatch("_init");
        cboMidiChannel.SelectedIndexChanged += (o, e) => patch.MidiChannel = cboMidiChannel.Text == "All" || cboMidiChannel.Text == "" ? null : int.Parse(cboMidiChannel.Text);
        patch.MidiControllerChanged += Patch_MidiControllerChanged;
        cmdViewWave.Click += (o, e) => { frmWaveViewer viewer = new(patch.SynthEngine); viewer.Show(); };
        
        // Module Group selector switches/leds
        ledVCO1.Click += (o, e) => GroupLedClicked(o);
        ledVCO2.Click += (o, e) => GroupLedClicked(o);
        ledVCO3.Click += (o, e) => GroupLedClicked(o);
        ledMixer.Click += (o, e) => GroupLedClicked(o);
        ledBitCrush.Click += (o, e) => GroupLedClicked(o);
        ledEnv1.Click += (o, e) => GroupLedClicked(o);
        ledEnv2.Click += (o, e) => GroupLedClicked(o);
        ledEnv3.Click += (o, e) => GroupLedClicked(o);
        ledEnv4.Click += (o, e) => GroupLedClicked(o);
        ledLFO.Click += (o, e) => GroupLedClicked(o);
        ledVCF.Click += (o, e) => GroupLedClicked(o);
        ledVcas.Click += (o, e) => GroupLedClicked(o);
        ledEffects.Click += (o, e) => GroupLedClicked(o);

        cmdControllers.Click += (o, e) => {
            var frm = new frmControlMapping {
                form = this
            };
            frm.ShowDialog();
            _controlMapping = Json<List<ControlKnobMap>>.Load(Constants.MIDI_TO_KNOB_MAPPING_FILE);
        };

        // Modules
        kVco1Freq.ValueChanged += (o, e) => patch.Vco1_FineTune = kVco1Freq.Value;
        kVco1Octave.ValueChanged += (o, e) => patch.Vco1_Octave = kVco1Octave.IntValue;

        kVco1Waveform.ValueChanged += (o, e) => patch.Vco1_WaveFormType = (VCOWaveformType)kVco1Waveform.IntValue;
        kVco1PW.ValueChanged += (o, e) => patch.Vco1_PulseWidth = kVco1PW.Value;

        kVco2Freq.ValueChanged += (o, e) => patch.Vco2_FineTune = kVco2Freq.Value;
        kVco2Octave.ValueChanged += (o, e) => patch.Vco2_Octave = kVco2Octave.IntValue;
        kVco2Waveform.ValueChanged += (o, e) => patch.Vco2_WaveFormType = (VCOWaveformType)kVco2Waveform.IntValue;
        kVco2PW.ValueChanged += (o, e) => patch.Vco2_PulseWidth = kVco2PW.Value;

        kVco3Freq.ValueChanged += (o, e) => patch.Vco3_FineTune = kVco3Freq.Value;
        kVco3Octave.ValueChanged += (o, e) => patch.Vco3_Octave = kVco3Octave.IntValue;
        kVco3Waveform.ValueChanged += (o, e) => patch.Vco3_WaveFormType = (VCOWaveformType)kVco3Waveform.IntValue;
        kVco3PW.ValueChanged += (o, e) => patch.Vco3_PulseWidth = kVco3PW.Value;

        kOsc1Mix.ValueChanged += (o, e) => patch.MixerVco1Level = kOsc1Mix.Value;
        kOsc2Mix.ValueChanged += (o, e) => patch.MixerVco2Level = kOsc2Mix.Value;
        kOsc3Mix.ValueChanged += (o, e) => patch.MixerVco3Level = kOsc3Mix.Value;
        kNoiseMix.ValueChanged += (o, e) => patch.MixerNoiseLevel = kNoiseMix.Value;

        kBitCrushSampleRate.ValueChanged += (o, e) => patch.BitCrush_SampleRate = kBitCrushSampleRate.Value;
        kBitCrushResolution.ValueChanged += (o, e) => patch.BitCrush_Resolution = kBitCrushResolution.Value;
        kGlide.ValueChanged += (o, e) => patch.Glide = kGlide.Value;

        kVcfType.ValueChanged += (o, e) => patch.FilterType = (Synth.Enums.FilterType)kVcfType.IntValue;
        kVcfType.ValueChanged += (o, e) => FilterTypeChanged();
        kVcfCutoff.ValueChanged += (o, e) => patch.VcfCutoff = kVcfCutoff.Value;
        kVcfEnvelope.ValueChanged += (o, e) => patch.VcfEnvelopeAmount = kVcfEnvelope.Value;
        // This gets routed to different param depending on filter type, so use the All New switch expression!!
        kVcfResonance.ValueChanged += (o, e) => {
            _ = kVcfType.Value switch {
                (int)Enums.FilterType.Butterworth => patch.VcfResonance = kVcfResonance.Value,
                (int)Enums.FilterType.Chebyshev => patch.VcfRippleFactor = kVcfResonance.Value,
                (int)Enums.FilterType.BandPass or (int)Enums.FilterType.Notch => patch.VcfBandwidth = kVcfResonance.Value,
                _ => default // Default case does nothing
            };
        };

        kEnv1Attack.ValueChanged += (o, e) => patch.VcfEnvAttack = kEnv1Attack.Value;
        kEnv1Decay.ValueChanged += (o, e) => patch.VcfEnvDecay = kEnv1Decay.Value;
        kEnv1Sustain.ValueChanged += (o, e) => patch.VcfEnvSustain = kEnv1Sustain.Value;
        kEnv1Release.ValueChanged += (o, e) => patch.VcfEnvRelease = kEnv1Release.Value;

        kEnv2Attack.ValueChanged += (o, e) => patch.VcaEnvAttack = kEnv2Attack.Value;
        kEnv2Decay.ValueChanged += (o, e) => patch.VcaEnvDecay = kEnv2Decay.Value;
        kEnv2Sustain.ValueChanged += (o, e) => patch.VcaEnvSustain = kEnv2Sustain.Value;
        kEnv2Release.ValueChanged += (o, e) => patch.VcaEnvRelease = kEnv2Release.Value;

        kEffectType.ValueChanged += (o, e) => patch.EffectType = (EffectType)kEffectType.IntValue;
        kEffectType.ValueChanged += (o, e) => EffectTypeChanged();
        kEffectParam1.ValueChanged += (o, e) => patch.EffectParam1 = kEffectParam1.Value;
        kEffectParam2.ValueChanged += (o, e) => patch.EffectParam2 = kEffectParam2.Value;
        kEffectMix.ValueChanged += (o, e) => patch.EffectMix = kEffectMix.Value;

        kLfo1Rate.ValueChanged += (o, e) => patch.Lfo1_Frequency = kLfo1Rate.Value;
        kLfo1Shape.ValueChanged += (o, e) => patch.Lfo1_WaveformType = (LFOWaveformType)kLfo1Shape.IntValue;
        kLfo2Rate.ValueChanged += (o, e) => patch.Lfo2_Frequency = kLfo2Rate.Value;
        kLfo2Shape.ValueChanged += (o, e) => patch.Lfo2_WaveformType = (LFOWaveformType)kLfo2Shape.IntValue;

        patch.Lfo1StateChanged += (o, e) => ledLfo1.LedState = e ? Led.Enums.LedState.On : Led.Enums.LedState.Off;
        patch.Lfo2StateChanged += (o, e) => ledLfo2.LedState = e ? Led.Enums.LedState.On : Led.Enums.LedState.Off;
        patch.KeyChanged += (o, e) => {
            _ = e.Value.Item1 switch {
                0 => ledGate1.LedState = e.Value.Item2 ? Led.Enums.LedState.On : Led.Enums.LedState.Off,
                1 => ledGate2.LedState = e.Value.Item2 ? Led.Enums.LedState.On : Led.Enums.LedState.Off,
                2 => ledGate3.LedState = e.Value.Item2 ? Led.Enums.LedState.On : Led.Enums.LedState.Off,
                3 => ledGate4.LedState = e.Value.Item2 ? Led.Enums.LedState.On : Led.Enums.LedState.Off,
                4 => ledGate5.LedState = e.Value.Item2 ? Led.Enums.LedState.On : Led.Enums.LedState.Off,
                _ => throw new InvalidOperationException("Invalid value for e.Value.Item1.")
            };
        };
    }
    #endregion

    #region Midi Controller Event Handler
    private void Patch_MidiControllerChanged(object? sender, MidiControllerEventArgs e) {
        // Are we in group mode?
        string? controlName = null;
        int? index = null;

        if (controlGroup != null) {
            // Get Knob from control group
            for (int i = 0; i < 4; i++) {
                if (_controlMapping[i].ControllerID == e.ControllerID) {
                    index = i;
                    break;
                }
            }

            if (index != null) {
                var group = knobGroups[(ControlGroup)controlGroup];
                controlName = group[(int)index];
            }
        }

        // If not in group mode, get knob from mapping  (but get controller 5 up from mapping in any case as we've only got max 4 kobs in a group)
        if (index == null) {
            controlName = _controlMapping.FirstOrDefault(i => i.ControllerID == e.ControllerID)?.KnobName;
            if (controlName == null)
                return;
        }

        var knob = (Knob)(Controls.Find(controlName, false)[0]);
        knob.Value = (double)e.Value / 127.0 * (knob.Max - knob.Min) + knob.Min;
    }

    private void FilterTypeChanged() {
        if (!formLoaded)
            return;

        string filterTypeText = string.Empty;
        string resonanceLabelText = string.Empty;
        double resonanceValue = 0.0;

        switch (kVcfType.Value) {
            case (int)Enums.FilterType.RC: 
                filterTypeText = "Low Pass RC 1 pole"; resonanceLabelText = "n/a"; break;
            case (int)Enums.FilterType.Butterworth: 
                filterTypeText = "Low Pass Butterworth 2 pole"; resonanceLabelText = "RESONANCE"; resonanceValue = kVcfResonance.Value; break;
            case (int)Enums.FilterType.Chebyshev: 
                filterTypeText = "Low Pass Chebyshev 2 pole"; resonanceLabelText = "RIPPLE"; resonanceValue = kVcfResonance.Value; break;
            case (int)Enums.FilterType.Bessel: 
                filterTypeText = "Low Pass Bessel 2 pole"; resonanceLabelText = "n/a"; break;
            case (int)Enums.FilterType.BandPass: 
                filterTypeText = "Band Pass"; resonanceLabelText = "BANDWIDTH"; resonanceValue = kVcfResonance.Value; break;
            case (int)Enums.FilterType.Notch:
                // Ideally need attenuation as well
                filterTypeText = "Notch Pass"; resonanceLabelText = "BANDWIDTH"; resonanceValue = kVcfResonance.Value; break;
            default: break;
        }

        this.BeginInvoke((MethodInvoker)(() => lblFilterType.Text = filterTypeText));
        this.BeginInvoke((MethodInvoker)(() => kVcfResonance.LabelText = resonanceLabelText));

        patch.VcfResonance = resonanceValue;
        patch.VcfEnvelopeAmount = kVcfEnvelope.Value;
    }

    private void EffectTypeChanged() {
        if (!formLoaded)
            return;

        string effectTypeText = string.Empty;
        string param1LabelText = string.Empty;
        string param2LabelText = string.Empty;

        switch (kEffectType.Value) {
            case (int)EffectType.None:
                effectTypeText = "None"; param1LabelText = "n/a"; param2LabelText = "n/a"; break;
            case (int)EffectType.Chorus:
                effectTypeText = "Chorus"; param1LabelText = "FREQUENCY"; param2LabelText = "DELAY"; break;
            case (int)EffectType.Reverb:
                effectTypeText = "Reverb"; param1LabelText = "GAIN"; param2LabelText = "DELAY LENGTH"; break;
            case (int)EffectType.AllPass:
                effectTypeText = "All Pass Filter"; param1LabelText = "GAIN"; param2LabelText = "DELAY LENGTH"; break;
            case (int)EffectType.FeedbackComb:
                effectTypeText = "Feedback Comb Filter"; param1LabelText = "GAIN"; param2LabelText = "DELAY LENGTH"; break;
            case (int)EffectType.FeedForwardComb:
                effectTypeText = "Feed Forward Comb Filter"; param1LabelText = "GAIN"; param2LabelText = "DELAY LENGTH"; break;
            default:
                break;
        }

        lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = effectTypeText));
        kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = param1LabelText));
        kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = param2LabelText));
    }
    #endregion

    #region Control Groups
    enum ControlGroup {
        ledVCO1,
        ledVCO2,
        ledVCO3,
        ledMixer,
        ledBitCrush,
        ledEnv1,
        ledEnv2,
        ledEnv3,
        ledEnv4,
        ledLFO,
        ledVCF,
        ledVcas,
        ledEffects
    }

    private readonly Dictionary<ControlGroup, List<string>> knobGroups = new();

    void InitKnobGroups() { 
        knobGroups.Add(ControlGroup.ledVCO1, new List<string>() { "kVco1Freq", "kVco1Octave", "kVco1Waveform", "kVco1PW" });
        knobGroups.Add(ControlGroup.ledVCO2, new List<string>() { "kVco2Freq", "kVco2Octave", "kVco2Waveform", "kVco2PW" });
        knobGroups.Add(ControlGroup.ledVCO3, new List<string>() { "kVco3Freq", "kVco3Octave", "kVco3Waveform", "kVco3PW" });
        knobGroups.Add(ControlGroup.ledLFO, new List<string>() { "kLfo1Rate", "kLfo1Shape", "kLfo2Rate", "kLfo2Shape" });
        knobGroups.Add(ControlGroup.ledMixer, new List<string>() { "kOsc1Mix", "kOsc2Mix", "kOsc3Mix", "kNoiseMix" });
        knobGroups.Add(ControlGroup.ledBitCrush, new List<string>() { "kBitCrushSampleRate", "kBitCrushResolution", "kGlide", "kGlide" });
        knobGroups.Add(ControlGroup.ledVCF, new List<string>() { "kVcfType", "kVcfCutoff", "kVcfResonance", "kVcfEnvelope" });
        knobGroups.Add(ControlGroup.ledEnv1, new List<string>() { "kEnv1Attack", "kEnv1Decay", "kEnv1Sustain", "kEnv1Release" });
        knobGroups.Add(ControlGroup.ledEnv2, new List<string>() { "kEnv2Attack", "kEnv2Decay", "kEnv2Sustain", "kEnv2Release" });
        knobGroups.Add(ControlGroup.ledEnv3, new List<string>() { "kEnv3Attack", "kEnv3Decay", "kEnv3Sustain", "kEnv3Release" });
        knobGroups.Add(ControlGroup.ledEnv4, new List<string>() { "kEnv4Attack", "kEnv4Decay", "kEnv4Sustain", "kEnv4Release" });
        knobGroups.Add(ControlGroup.ledEffects, new List<string>() { "kEffectType", "kEffectParam1", "kEffectParam2", "kEffectMix" });
        knobGroups.Add(ControlGroup.ledVcas, new List<string>() { "kVca2", "kVca3", "kVca4", "kVca5" });
    }


    ControlGroup? controlGroup = null;

    private void GroupLedClicked(object? o) {
        if (o == null)
            return;

        Led led = (Led)o;

        if (led.LedState == Led.Enums.LedState.Off) {
            controlGroup = null;
            return;
        }

        leds.Where(l => l.Name != led.Name).ToList().ForEach(l => { l.LedState = Led.Enums.LedState.Off; });

        controlGroup = led switch {
            Led l when ReferenceEquals(l, ledBitCrush) => (ControlGroup?)ControlGroup.ledBitCrush,
            Led l when ReferenceEquals(l, ledVCO1) => (ControlGroup?)ControlGroup.ledVCO1,
            Led l when ReferenceEquals(l, ledVCO2) => (ControlGroup?)ControlGroup.ledVCO2,
            Led l when ReferenceEquals(l, ledVCO3) => (ControlGroup?)ControlGroup.ledVCO3,
            Led l when ReferenceEquals(l, ledMixer) => (ControlGroup?)ControlGroup.ledMixer,
            Led l when ReferenceEquals(l, ledEnv1) => (ControlGroup?)ControlGroup.ledEnv1,
            Led l when ReferenceEquals(l, ledEnv2) => (ControlGroup?)ControlGroup.ledEnv2,
            Led l when ReferenceEquals(l, ledEnv3) => (ControlGroup?)ControlGroup.ledEnv3,
            Led l when ReferenceEquals(l, ledEnv4) => (ControlGroup?)ControlGroup.ledEnv4,
            Led l when ReferenceEquals(l, ledLFO) => (ControlGroup?)ControlGroup.ledLFO,
            Led l when ReferenceEquals(l, ledVCF) => (ControlGroup?)ControlGroup.ledVCF,
            Led l when ReferenceEquals(l, ledVcas) => (ControlGroup?)ControlGroup.ledVcas,
            Led l when ReferenceEquals(l, ledEffects) => (ControlGroup?)ControlGroup.ledEffects,
            _ => null,
        };
    }
    #endregion
}

