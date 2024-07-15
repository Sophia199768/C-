using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryHull
{
    public RepositoryHull()
    {
        HullList.Add(new BigHullDirector().Create(new HullBuilder()).FinishBuild());
        HullList.Add(new MediumHullDirector().Create(new HullBuilder()).FinishBuild());
        HullList.Add(new SmallHullDirector().Create(new HullBuilder()).FinishBuild());
    }

    private List<IHull> HullList { get; } = new List<IHull>();

    public void Add(IHull newCpu)
    {
        HullList.Add(newCpu);
    }

    public IEnumerable<IHull> Get()
    {
        return HullList;
    }
}