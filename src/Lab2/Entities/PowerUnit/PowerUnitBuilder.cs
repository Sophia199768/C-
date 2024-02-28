namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class PowerUnitBuilder
{
    public PowerUnitBuilder(PowerUnit powerUnit) => ComputerPowerUnit = powerUnit;
    public PowerUnitBuilder() => ComputerPowerUnit = new PowerUnit();
    public PowerUnit ComputerPowerUnit { get; }
    public PowerUnitBuilder SetPeakLoad(double peakLoad)
    {
        ComputerPowerUnit.PeakLoad = peakLoad;
        return this;
    }

    public PowerUnitBuilder SetCost(int cost)
    {
        ComputerPowerUnit.Cost = cost;
        return this;
    }

    public IPowerUnit FinishBuild()
    {
        return ComputerPowerUnit;
    }
}