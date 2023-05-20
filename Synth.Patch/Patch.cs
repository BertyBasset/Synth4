using Synth.IO;
using Synth.Keyboard.Controllers;
using Synth.Keyboard;
using Synth.Modules.Effects;
using Synth.Modules.Modifiers.Filters;
using Synth.Modules.Modifiers;
using Synth.Modules.Modulators;
using Synth.Modules.Sources;
using Synth.Properties;

namespace Synth;

public class Patch {
    Synth.SynthEngine engine = new Synth.SynthEngine();
    const int NUM_VOICES = 5;
    PolyKeyboard polyKbd = new(NUM_VOICES);

    // Voice Level Modules
    List<Voice> voices = Enumerable.Range(0, NUM_VOICES).Select(i => new Voice()).ToList();
    //                                                                      Change property to WaveFormType so we can just pass type in rather than having to create a new object
    List<VCO> vco = Enumerable.Range(0, NUM_VOICES).Select(i => new VCO() { WaveFormType = VCOWaveformType.Saw }).ToList();
    List<VCF> vcf = Enumerable.Range(0, NUM_VOICES).Select(i => new VCF() { Cutoff = .1, Resonance = 1, FilterType = Enums.FilterType.Butterworth, ModAmount = 1 }).ToList();
    List<VCA> vca = Enumerable.Range(0, NUM_VOICES).Select(i => new VCA()).ToList();
    List<EnvGen> env = Enumerable.Range(0, NUM_VOICES).Select(i => new EnvGen() { Attack = .05, Decay = .2, Sustain = .8, Release = .4 }).ToList();
    List<AudioOut> voiceOut = Enumerable.Range(0, NUM_VOICES).Select(i => new AudioOut()).ToList();

    // Synth Level Modules
    ModWheel mw = new ModWheel();
    Mixer voiceMixer = new Mixer();
    Effects effects = new Effects() { EffectType = Enums.EffectType.FeedbackComb, Mix = 1, Param1 = .6, Param2 = .6 };
    AudioOut audioOut = new();

    public Patch() {
        Init();
    }

    void Init() {
        polyKbd.DebugEvent += (o, e) => System.Console.WriteLine(e.Value);

        // Patch Voice level modules together
        for (int i = 0; i < NUM_VOICES; i++) {
            // Put modules for voice into a voice
            voices[i].Modules.Add(polyKbd.keys[i].MonoKeyboard);    // Remeber to add keyboard to voice as well as it also implements Tick to provide Glide
            voices[i].Modules.Add(vco[i]);
            voices[i].Modules.Add(vcf[i]);
            voices[i].Modules.Add(vca[i]);
            voices[i].Modules.Add(env[i]);
            voices[i].Modules.Add(voiceOut[i]);
            engine.Modules.Add(voices[i]);

            // Hook modules together - Source and Modulator to iModules
            vco[i].Frequency.Keyboard = polyKbd.keys[i].MonoKeyboard;
            env[i].Keyboard = polyKbd.keys[i].MonoKeyboard;
            vcf[i].Source = vco[i];
            vcf[i].Modulator = mw;
            vca[i].Source = vcf[i];
            vca[i].Modulator = env[i];
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
}