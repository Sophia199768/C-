namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class NullPowerUnit : IPowerUnit
{
    private const int PowerUnitPeakLoad = 0;
    private const int PowerUnitCost = 0;
    public NullPowerUnit()
    {
        PeakLoad = PowerUnitPeakLoad;
        Cost = PowerUnitCost;
    }

    public double PeakLoad { get; set; }
    public int Cost { get; set; }

    public PowerUnitBuilder Clone()
    {
        return new PowerUnitBuilder(new PowerUnit(PeakLoad, Cost));
    }
}