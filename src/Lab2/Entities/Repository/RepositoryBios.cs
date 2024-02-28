using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryBios
{
    public RepositoryBios()
    {
        BiosList.Add(new AMIDirector().Create(new BiosBuilder()).FinishBuild());
        BiosList.Add(new UEFIFactory().Create(new BiosBuilder()).FinishBuild());
        BiosList.Add(new AwardDirector().Create(new BiosBuilder()).FinishBuild());
    }

    private List<IBios> BiosList { get; } = new List<IBios>();

    public void Add(IBios newCpu)
    {
        BiosList.Add(newCpu);
    }

    public IEnumerable<IBios> Get()
    {
        return BiosList;
    }
}