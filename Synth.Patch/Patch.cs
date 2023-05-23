﻿using System.Reflection;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Synth;


// ****** CRUSHER & MOD WHEEL TO CONNECT


public class Patch {

    public int a;

    #region Intiallise 1 - Declare all modules
    Synth.SynthEngine engine = new ();
    const int NUM_VOICES = 5;
    PolyKeyboard polyKbd = new(NUM_VOICES);

    // Voice Level Modules
    List<Voice> voices = Enumerable.Range(0, NUM_VOICES).Select(i => new Voice()).ToList();        //
    List<VCO> vco1 = Enumerable.Range(0, NUM_VOICES).Select(i => new VCO()).ToList();        // { WaveFormType = VCOWaveformType.SuperSaw }).ToList();
    List<VCO> vco2 = Enumerable.Range(0, NUM_VOICES).Select(i => new VCO()).ToList();        // { WaveFormType = VCOWaveformType.Square}).ToList();
    List<VCO> vco3 = Enumerable.Range(0, NUM_VOICES).Select(i => new VCO()).ToList();        // { WaveFormType = VCOWaveformType.Saw }).ToList();
    List<Noise> noise = Enumerable.Range(0, NUM_VOICES).Select(i => new Noise()).ToList();
    List<Mixer> vcoMixer = Enumerable.Range(0, NUM_VOICES).Select(i => new Mixer()).ToList();
    List<BitCrusher> crusher=Enumerable.Range(0, NUM_VOICES).Select(i => new BitCrusher() { SampleRate = 0, Resolution = 0}).ToList();
    List<EnvGen> envVcf = Enumerable.Range(0, NUM_VOICES).Select(i => new EnvGen() { Attack = .05, Decay = .2, Sustain = .8, Release = .4 }).ToList();
    List<VCF> vcf = Enumerable.Range(0, NUM_VOICES).Select(i => new VCF() { Cutoff = .1, Resonance = 1, FilterType = Enums.FilterType.Butterworth, ModAmount = 1 }).ToList();
    List<EnvGen> envVca = Enumerable.Range(0, NUM_VOICES).Select(i => new EnvGen() { Attack = .05, Decay = .2, Sustain = .8, Release = .4 }).ToList();
    List<VCA> vca = Enumerable.Range(0, NUM_VOICES).Select(i => new VCA()).ToList();
    List<AudioOut> voiceOut = Enumerable.Range(0, NUM_VOICES).Select(i => new AudioOut()).ToList();

    // Synth Level Modules
    ModWheel mw = new ();
    Mixer voiceMixer = new ();
    Effects effects = new () { EffectType = Enums.EffectType.FeedbackComb, Mix = -.7, Param1 = .6, Param2 = .6 };
    AudioOut audioOut = new();
    #endregion

    #region Initiallse 2 - Patch modules together and add them either to a separate voice, or to the Synth Engine
    public Patch() {
        Init();
    }

    void Init() {
        polyKbd.DebugEvent += (o, e) => System.Console.WriteLine(e.Value);

        // Patch Voice level modules together
        for (int i = 0; i < NUM_VOICES; i++) {
            // Put modules for voice into a voice
            voices[i].Modules.Add(polyKbd.keys[i].MonoKeyboard);    // Remeber to add keyboard to voice as well as it also implements Tick to provide Glide
            voices[i].Modules.Add(vco1[i]);
            voices[i].Modules.Add(vco2[i]);
            voices[i].Modules.Add(vco3[i]);
            voices[i].Modules.Add(noise[i]);
            voices[i].Modules.Add(vcoMixer[i]);
            voices[i].Modules.Add(crusher[i]);
            voices[i].Modules.Add(envVcf[i]);
            voices[i].Modules.Add(vcf[i]);
            voices[i].Modules.Add(envVca[i]);
            voices[i].Modules.Add(vca[i]);
            voices[i].Modules.Add(voiceOut[i]);
            engine.Modules.Add(voices[i]);

            // Hook modules together - Source and Modulator to iModules
            vco1[i].Frequency.Keyboard = polyKbd.keys[i].MonoKeyboard;
            vco2[i].Frequency.Keyboard = polyKbd.keys[i].MonoKeyboard;
            vco2[i].Frequency.FineTune = -.01;
            vco3[i].Frequency.Keyboard = polyKbd.keys[i].MonoKeyboard;
            vco3[i].Frequency.FineTune = .01;
            vco3[i].Frequency.Octave = -1;

            vcoMixer[i].Sources.Add(vco1[i]);
            vcoMixer[i].Sources.Add(vco2[i]);
            vcoMixer[i].Sources.Add(vco3[i]);
            vcoMixer[i].Sources.Add(noise[i]);
            vcoMixer[i].Levels[0] = 1;   // <<<<<<<<<<<<<<<<
            vcoMixer[i].Levels[1] = 1;
            vcoMixer[i].Levels[2] = 1;
            crusher[i].Source = vcoMixer[i];
            envVcf[i].Keyboard = polyKbd.keys[i].MonoKeyboard;
            vcf[i].Modulator = envVcf[i];
            vcf[i].Source = crusher[i];
            envVca[i].Keyboard = polyKbd.keys[i].MonoKeyboard;
            vca[i].Source = vcf[i];
            vca[i].Modulator = envVca[i];
            voiceOut[i].Source = vca[i];
            voiceMixer.Sources.Add(voiceOut[i]);
            voiceMixer.Levels[i] = 1;
        }

        // Patch Synth level modules together
        effects.Source = voiceMixer;
        audioOut.Source = effects;

        engine.Modules.Add(mw);
        engine.Modules.Add(voiceMixer);
        engine.Modules.Add(effects);
        engine.Modules.Add(audioOut);

    }
    #endregion

    #region Module Properties
    #region Oscillators
    public int Vco1_Octave {
        set => vco1.ForEach(vco => vco.Frequency.Octave = value);
        get => vco1.FirstOrDefault().Frequency.Octave;
    }
    public double Vco1_FineTune { 
        set => vco1.ForEach (vco => vco.Frequency.FineTune = value);
        get => vco1.FirstOrDefault().Frequency.FineTune;
    }
    public double Vco1_PulseWidth {
        set => vco1.ForEach(vco => vco.Duty.Value = value);
        get => vco1.FirstOrDefault().Duty.Value;
    }
    public VCOWaveformType Vco1_WaveFormType {
        set => vco1.ForEach(vco => vco.WaveFormType = value);
        get => vco1.FirstOrDefault().WaveFormType;
    }
    public int Vco2_Octave {
        set => vco2.ForEach(vco => vco.Frequency.Octave = value);
        get => vco2.FirstOrDefault().Frequency.Octave;
    }
    public double Vco2_FineTune {
        set => vco2.ForEach(vco => vco.Frequency.FineTune = value);
        get => vco2.FirstOrDefault().Frequency.FineTune;
    }
    public double Vco2_PulseWidth {
        set => vco2.ForEach(vco => vco.Duty.Value = value);
        get => vco2.FirstOrDefault().Duty.Value;
    }
    public VCOWaveformType Vco2_WaveFormType {
        set => vco2.ForEach(vco => vco.WaveFormType = value);
        get => vco2.FirstOrDefault().WaveFormType;
    }
    public int Vco3_Octave {
        set => vco3.ForEach(vco => vco.Frequency.Octave = value);
        get => vco3.FirstOrDefault().Frequency.Octave;
    }
    public double Vco3_FineTune {
        set => vco3.ForEach(vco => vco.Frequency.FineTune = value);
        get => vco3.FirstOrDefault().Frequency.FineTune;
    }
    public double Vco3_PulseWidth {
        set => vco3.ForEach(vco => vco.Duty.Value = value);
        get => vco3.FirstOrDefault().Duty.Value;
    }
    public VCOWaveformType Vco3_WaveFormType {
        set => vco3.ForEach(vco => vco.WaveFormType = value);
        get => vco3.FirstOrDefault().WaveFormType;
    }
    #endregion
    #region Oscillator/Noise Mixer
    private enum MixerSource { 
        Vco1,
        Vco2,
        Vco3,
        Noise
    }
    public double MixerVco1Level { 
        set => vcoMixer.ForEach(mixer => mixer.Levels[(int)MixerSource.Vco1] = value);
        get => vcoMixer.FirstOrDefault().Levels[(int)MixerSource.Vco1];
    }
    public double MixerVco2Level {
        set => vcoMixer.ForEach(mixer => mixer.Levels[(int)MixerSource.Vco2] = value);
        get => vcoMixer.FirstOrDefault().Levels[(int)MixerSource.Vco2];

    }
    public double MixerVco3Level {
        set => vcoMixer.ForEach(mixer => mixer.Levels[(int)MixerSource.Vco3] = value);
        get => vcoMixer.FirstOrDefault().Levels[(int)MixerSource.Vco3];
    }
    public double MixerNoiseLevel {
        set => vcoMixer.ForEach(mixer => mixer.Levels[(int)MixerSource.Noise] = value);
        get => vcoMixer.FirstOrDefault().Levels[(int)MixerSource.Noise];
    }


    #endregion

    #region BitCrush + Glide
    public double BitCrush_SampleRate {
        set => crusher.ForEach(crush => crush.SampleRate = value);
        get => crusher.FirstOrDefault().SampleRate;
    }

    public double BitCrush_Resolution {
        set => crusher.ForEach(crush => crush.Resolution = value);
        get => crusher.FirstOrDefault().Resolution;
    }

    public double Glide {
        set => polyKbd.keys.ForEach(key => key.MonoKeyboard.Glide = value);
        get => polyKbd.keys.FirstOrDefault().MonoKeyboard.Glide;
    }

    #endregion

    #region VCF + VCF Env
    public Synth.Enums.FilterType FilterType {
        set => vcf.ForEach(vcf => vcf.FilterType = value);
        get => vcf.FirstOrDefault().FilterType;
    }

    public double VcfCutoff {
        set => vcf.ForEach(vcf => vcf.Cutoff = value);
        get => vcf.FirstOrDefault().Cutoff;
    }

    public double VcfEnvelopeAmount {
        set => vcf.ForEach(vcf => vcf.ModAmount = value);
        get => vcf.FirstOrDefault().ModAmount;
    }

    public double VcfRippleFactor {
        set => vcf.ForEach(vcf => vcf.RippleFactor = value);
        get => vcf.FirstOrDefault().RippleFactor;

    }

    public double VcfResonance {
        set => vcf.ForEach(vcf => vcf.Resonance = value);
        get => vcf.FirstOrDefault().Resonance;
    }

    public double VcfBandwidth {
        set => vcf.ForEach(vcf => vcf.Bandwidth = value);
        get => vcf.FirstOrDefault().Bandwidth;
    }

    // **** VCF Envelope 
    public double VcfEnvAttack {
        set => envVcf.ForEach(vcf => vcf.Attack = value);
        get => envVcf.FirstOrDefault().Attack;
    }

    public double VcfEnvDecay {
        set => envVcf.ForEach(vcf => vcf.Decay = value);
        get => envVcf.FirstOrDefault().Decay;
    }

    public double VcfEnvSustain {
        set => envVcf.ForEach(vcf => vcf.Sustain = value);
        get => envVcf.FirstOrDefault().Sustain;
    }

    public double VcfEnvRelease {
        set => envVcf.ForEach(vcf => vcf.Release = value);
        get => envVcf.FirstOrDefault().Release;
    }
    #endregion


    #region VCA + VCA Env
    public double VcaEnvAttack {
        set => envVca.ForEach(vca => vca.Attack = value);
        get => envVca.FirstOrDefault().Attack;
    }

    public double VcaEnvDecay {
        set => envVca.ForEach(vca => vca.Decay = value);
        get => envVca.FirstOrDefault().Decay;
    }

    public double VcaEnvSustain {
        set => envVca.ForEach(vca => vca.Sustain = value);
        get => envVca.FirstOrDefault().Sustain;
    }

    public double VcaEnvRelease {
        set => envVca.ForEach(vca => vca.Release = value);
        get => envVca.FirstOrDefault().Release;
    }

    #endregion

    #region Effects - This is module not voice level, so no needs for foreach
    public Enums.EffectType EffectType {
        set => effects.EffectType = (Enums.EffectType)value;
        get => effects.EffectType;
    }

    public double EffectParam1 {
        set => effects.Param1 = value;
        get => effects.Param1;
    }

    public double EffectParam2 {
        set => effects.Param2 = value;
        get => effects.Param2;
    }

    public double EffectMix {
        set => effects.Mix = value;
        get => effects.Mix;

    }

    public int? MidiChannel {
        set => polyKbd.MidiChannel = value;
        get => polyKbd.MidiChannel;
    }

    public SynthEngine SynthEngine { 
        get => engine;
    }

    #endregion
    #endregion
}