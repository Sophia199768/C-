namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class PowerUnit : IPowerUnit
{
    public PowerUnit(double peakLoad, int cost)
    {
        PeakLoad = peakLoad;
        Cost = cost;
    }

    public PowerUnit()
    {
    }

    public double PeakLoad { get; set; }
    public int Cost { get; set; }

    public PowerUnitBuilder Clone()
    {
        return new PowerUnitBuilder(new PowerUnit(PeakLoad, Cost));
    }
}