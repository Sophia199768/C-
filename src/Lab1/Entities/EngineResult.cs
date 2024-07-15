namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract record EngineResult
{
    private EngineResult() { }

    public sealed record SuccessUsedPulsedEngine(int AmountOfFuel, int Time) : EngineResult;

    public sealed record SuccessUsedJumpEngine(int AmountOfFuel, int Time) : EngineResult;
    public sealed record FailEngine(string DefaultMessage) : EngineResult;
}