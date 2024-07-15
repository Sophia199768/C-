namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class BigPowerUnitDirector : IPowerUnitDirector
{
    private double _peakLoad = 1000;
    private int _cost = 19490;

    public PowerUnitBuilder Create(PowerUnitBuilder build)
    {
        build.SetCost(_cost);
        build.SetPeakLoad(_peakLoad);
        return build;
    }
}