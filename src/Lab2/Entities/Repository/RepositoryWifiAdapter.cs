using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryWifiAdapter
{
    public RepositoryWifiAdapter()
    {
        WifiList.Add(new WifiAdapterWN881NDDirector().Create(new WifiAdapterBuilder()).FinishBuild());
    }

    private List<IWifiAdapter> WifiList { get; } = new List<IWifiAdapter>();

    public void Add(IWifiAdapter newCpu)
    {
        WifiList.Add(newCpu);
    }

    public IEnumerable<IWifiAdapter> Get()
    {
        return WifiList;
    }
}