namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract record EnvironmentResult
{
    private EnvironmentResult() { }

    public sealed record ShipEnvironmentInfo(EngineResult Engine, HullInfoResult HullInfo) : EnvironmentResult;
    public sealed record CantPassEnvironment(string DefaultMessage) : EnvironmentResult;
}