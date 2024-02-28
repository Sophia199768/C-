using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public class CoolingSystemBuilder
{
    public CoolingSystemBuilder(CoolingSystem coolingSystemCooling) => SystemCooling = coolingSystemCooling;

    public CoolingSystemBuilder() => SystemCooling = new CoolingSystem();
    public CoolingSystem SystemCooling { get; }

    public CoolingSystemBuilder SetDimensions(int dimensions)
    {
        SystemCooling.Dimensions = dimensions;
        return this;
    }

    public CoolingSystemBuilder SetSokets(Collection<string> sokets)
    {
        SystemCooling.SetSokets(sokets);
        return this;
    }

    public CoolingSystemBuilder SetTDP(int tdp)
    {
        SystemCooling.TDP = tdp;
        return this;
    }

    public CoolingSystemBuilder SetCost(int cost)
    {
        SystemCooling.Cost = cost;
        return this;
    }

    public ICoolingSystem FinishBuild()
    {
        return SystemCooling;
    }
}