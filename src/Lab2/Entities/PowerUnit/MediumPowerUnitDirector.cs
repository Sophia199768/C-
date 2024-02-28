namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public class MediumPowerUnitDirector : IPowerUnitDirector
{
    private double _peakLoad = 700;
    private int _cost = 14120;

    public PowerUnitBuilder Create(PowerUnitBuilder build)
    {
        build.SetCost(_cost);
        build.SetPeakLoad(_peakLoad);
        return build;
    }
}