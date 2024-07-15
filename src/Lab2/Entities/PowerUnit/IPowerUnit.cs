namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public interface IPowerUnit
{
    public double PeakLoad { get; }
    public int Cost { get; }
    public PowerUnitBuilder Clone();
}