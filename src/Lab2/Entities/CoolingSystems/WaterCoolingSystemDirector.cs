using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public class WaterCoolingSystemDirector : ICoolingSystemDirector
{
    private int _dimensions = 120;
    private Collection<string> _sokets = new Collection<string>() { "LGA1700" };
    private int _tdp = 245;
    private int _waterCoolingSystemCost = 10140;

    public CoolingSystemBuilder Create(CoolingSystemBuilder builder)
    {
        builder.SetSokets(_sokets);
        builder.SetCost(_waterCoolingSystemCost);
        builder.SetTDP(_tdp);
        builder.SetDimensions(_dimensions);
        return builder;
    }
}