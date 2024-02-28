namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class SmallPowerUnitDirector : IPowerUnitDirector
{
    private double _peakLoad = 115;
    private int _cost = 2620;

    public PowerUnitBuilder Create(PowerUnitBuilder build)
    {
        build.SetCost(_cost);
        build.SetPeakLoad(_peakLoad);
        return build;
    }
}