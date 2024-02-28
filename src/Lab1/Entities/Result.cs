namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract record Result
{
    private Result() { }

    public sealed record PassageInfo(int AmountOfFuel, int Time, int Hp) : Result;
    public sealed record ShipWasBroken(string DefaultMessage) : Result;
}