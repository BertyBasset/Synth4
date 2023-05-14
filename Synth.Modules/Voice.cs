using Synth.Modules;
using Synth.IO;



// ************** We want to add a Mono Keyboard property to each voice, then each module in the voic will be connected to that keyboard

namespace Synth;
public class Voice : iModule {
    public List<iModule> Modules = new();

    #region iModule Members
    public double Value { get; set; }
    public void Tick(double timeIncrement) { 
        float wave = 0; ;
        foreach (var module in Modules) {
            module.Tick(timeIncrement);
            if(module.GetType() == typeof(AudioOut))
                wave += (float)module.Value;
        }
        Value = wave;

    }
    #endregion
}


