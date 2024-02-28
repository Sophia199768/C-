using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryCoolingSystem
{
    public RepositoryCoolingSystem()
    {
        CoolingSystemsList.Add(new WaterCoolingSystemDirector().Create(new CoolingSystemBuilder()).FinishBuild());
        CoolingSystemsList.Add(new AirCoolingSystemDirector().Create(new CoolingSystemBuilder()).FinishBuild());
    }

    private List<ICoolingSystem> CoolingSystemsList { get; } = new List<ICoolingSystem>();

    public void Add(ICoolingSystem newCpu)
    {
        CoolingSystemsList.Add(newCpu);
    }

    public IEnumerable<ICoolingSystem> Get()
    {
        return CoolingSystemsList;
    }
}