using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryRamMemory
{
    public RepositoryRamMemory()
    {
        RamMemoryList.Add(new KingstoneIramDirectors().Create(new RamBuilder()).FinishBuild());
    }

    private List<IRAMMemory> RamMemoryList { get; } = new List<IRAMMemory>();

    public void Add(IRAMMemory newCpu)
    {
        RamMemoryList.Add(newCpu);
    }

    public IEnumerable<IRAMMemory> Get()
    {
        return RamMemoryList;
    }
}