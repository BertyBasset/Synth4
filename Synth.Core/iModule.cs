namespace Synth.Core;

public interface iModule {
    // Each module needs to provide a Value - nominally between -1 and +1

    public double Value { get; }
    // When Tick occurs, each module must update its Value to reflect what i will be in TimeIncrement
    public void Tick(double TimeIncrement);
}

