namespace UI;
using Synth;
using Synth.Keyboard;
using Synth.Modules.Effects;
using Synth.Modules.Modifiers.Filters;
using Synth.Modules.Modulators;
using Synth.Properties;
using System.Security;
using System.Xml.Linq;
using UI.Code;
using UI.Controls;
using static Synth.Enums;


// Version 4

/*
// 1
Hoopkup Midi Controllers
Mod Wheel => VCF Env
Num Voices Selector
Gate for x Voices
LFO flash
Save Patch
Load Patch
View Wave
Repeat - either Note or Chord - controlled by Lfo1

*/
// 3 Modulation Matrix System - maybe have a bank of VCAs to modulate modulators?


public partial class frmMidiController : Form {
    Synth.Patch patch = new();


    bool formLoaded = false;
    #region Initiallise
    public frmMidiController() {
        InitializeComponent();

        InitEventHandlers();


        InitPatch();
    }




    #endregion


    #region Patches
    private void InitPatch() {
        
        if(!Persist.Exists("_autosave.json"))
            this.Controls.OfType<Knob>().ToList().ForEach(knob => knob.Value = knob.Value);
        else {
            LoadPatch("_autosave.json");
        }
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

        cmdViewWave.Click += (o, e) => { frmWaveViewer viewer = new(patch.SynthEngine); viewer.Show(); };



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

    }


    private void FilterTypeChanged() {
        if (!formLoaded)
            return;

        switch (kVcfType.Value) {
            case (int)Enums.FilterType.RC:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass RC 1 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case (int)Enums.FilterType.Butterworth:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Butterworth 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RESONANCE"));
                patch.VcfResonance = kVcfResonance.Value;
                break;
            case (int)Enums.FilterType.Chebyshev:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Chebyshev 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "RIPPLE"));
                patch.VcfRippleFactor = kVcfResonance.Value;
                break;
            case (int)Enums.FilterType.Bessel:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Low Pass Bessel 2 pole"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "n/a"));
                break;
            case (int)Enums.FilterType.BandPass:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Band Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                patch.VcfBandwidth = kVcfResonance.Value;
                break;
            case (int)Enums.FilterType.Notch:
                lblFilterType.Invoke((MethodInvoker)(() => lblFilterType.Text = "Notch Pass"));
                kVcfResonance.Invoke((MethodInvoker)(() => kVcfResonance.LabelText = "BANDWIDTH"));
                patch.VcfBandwidth = kVcfResonance.Value;

                // Ideally need attenuation as well
                break;
            default:
                break;
        }
        patch.VcfEnvelopeAmount = kVcfEnvelope.Value;
    }

    private void EffectTypeChanged() {
        if (!formLoaded)
            return;

        switch (kEffectType.Value) {
            case (int)EffectType.None:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "None"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "n/a"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "n/a"));
                break;
            case (int)EffectType.Chorus:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Chorus"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "FREQUENCY"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY"));
                break;
            case (int)EffectType.Reverb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Reverb"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                break;
            case (int)EffectType.AllPass:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "All Pass Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                break;
            case (int)EffectType.FeedbackComb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Feedback Comb Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                break;
            case (int)EffectType.FeedForwardComb:
                lblEffectType.Invoke((MethodInvoker)(() => lblEffectType.Text = "Feed Forward Comb Filter"));
                kEffectParam1.Invoke((MethodInvoker)(() => kEffectParam1.LabelText = "GAIN"));
                kEffectParam2.Invoke((MethodInvoker)(() => kEffectParam2.LabelText = "DELAY LENGTH"));
                break;
            default:
                break;
        }
        //effects.Param1 = kEffectParam1.Value;
        //effects.Param2 = kEffectParam2.Value;


        #endregion





    }
}

