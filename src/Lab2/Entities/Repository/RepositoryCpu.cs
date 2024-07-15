using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryCpu
{
    public RepositoryCpu()
    {
        CpuList.Add(new IntelCorei5Director().Create(new CpuBuilder()).FinishBuild());
        CpuList.Add(new IntelCorei7Director().Create(new CpuBuilder()).FinishBuild());
    }

    private List<ICpu> CpuList { get; } = new List<ICpu>();

    public void Add(ICpu newCpu)
    {
        CpuList.Add(newCpu);
    }

    public IEnumerable<ICpu> Get()
    {
        return CpuList;
    }
}