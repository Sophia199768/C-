using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public class CoolingSystem : ICoolingSystem
{
    private Collection<string> _sokets = new Collection<string>();
    public CoolingSystem(int dimensions, Collection<string> sokets, int tdp, int airCoolingSystemCost)
    {
        Dimensions = dimensions;
        _sokets = sokets;
        TDP = tdp;
        Cost = airCoolingSystemCost;
    }

    public CoolingSystem()
    {
    }

    public int Dimensions { get; set; }
    public int Cost { get; set; }
    public int TDP { get; set; }

    public CoolingSystemBuilder Clone()
    {
        return new CoolingSystemBuilder(new CoolingSystem(Dimensions, _sokets, TDP, Cost));
    }

    public void SetSokets(Collection<string> sokets)
    {
        _sokets = sokets;
    }

    public IEnumerable<string> GetSokets()
    {
        return _sokets;
    }
}