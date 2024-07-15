using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public class NullCoolingSystem : ICoolingSystem
{
    private const int CoolingSystemTDP = 0;
    private const int CoolingSystemCost = 0;
    private const int CoolingSystemDimension = 0;
    private Collection<string> _sokets = new Collection<string>();
    public NullCoolingSystem()
    {
        Dimensions = CoolingSystemDimension;
        _sokets = new Collection<string>();
        TDP = CoolingSystemTDP;
        Cost = CoolingSystemCost;
    }

    public int Dimensions { get; }
    public int Cost { get; }
    public int TDP { get; }
    public IEnumerable<string> GetSokets()
    {
        return _sokets;
    }

    public CoolingSystemBuilder Clone()
    {
        return new CoolingSystemBuilder(new CoolingSystem(Dimensions, _sokets, TDP, Cost));
    }
}