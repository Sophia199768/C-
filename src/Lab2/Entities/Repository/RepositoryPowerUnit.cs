using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryPowerUnit
{
    public RepositoryPowerUnit()
    {
        PowerUnitsList.Add(new BigPowerUnitDirector().Create(new PowerUnitBuilder()).FinishBuild());
        PowerUnitsList.Add(new MediumPowerUnitDirector().Create(new PowerUnitBuilder()).FinishBuild());
        PowerUnitsList.Add(new SmallPowerUnitDirector().Create(new PowerUnitBuilder()).FinishBuild());
    }

    private List<IPowerUnit> PowerUnitsList { get; } = new List<IPowerUnit>();

    public void Add(IPowerUnit newCpu)
    {
        PowerUnitsList.Add(newCpu);
    }

    public IEnumerable<IPowerUnit> Get()
    {
        return PowerUnitsList;
    }
}