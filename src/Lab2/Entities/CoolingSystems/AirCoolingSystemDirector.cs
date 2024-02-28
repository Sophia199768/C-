using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public class AirCoolingSystemDirector : ICoolingSystemDirector
{
    private int _dimensions = 152;
    private Collection<string> _sokets = new Collection<string>() { "LGA1700" };
    private int _tdp = 160;
    private int _airCoolingSystemCost = 2670;

    public CoolingSystemBuilder Create(CoolingSystemBuilder builder)
    {
        builder.SetDimensions(_dimensions);
        builder.SetSokets(_sokets);
        builder.SetTDP(_tdp);
        builder.SetCost(_airCoolingSystemCost);
        return builder;
    }
}