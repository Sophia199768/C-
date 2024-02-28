namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract record HullInfoResult
{
    private HullInfoResult() { }

    public sealed record HullIsNotCrushed(int Value) : HullInfoResult;
    public sealed record ShipIsNotCrushed(int Value) : HullInfoResult;
    public sealed record HullWasBroken(string DefaultMessage) : HullInfoResult;
    public sealed record DeflectorIsNotCrushed(int Hp) : HullInfoResult;
    public sealed record Fragments(Obstacles.Fragments Fragment, int Hp) : HullInfoResult;
}