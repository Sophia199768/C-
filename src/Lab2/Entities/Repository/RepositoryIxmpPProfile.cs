using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryIxmpPProfile
{
    public RepositoryIxmpPProfile()
    {
        XmpProfileList.Add(new KingstoneIxmpDirector().Create(new XmpProfileBuilder()).FinishBuild());
    }

    private List<IXMPProfile> XmpProfileList { get; } = new List<IXMPProfile>();

    public void Add(IXMPProfile newCpu)
    {
        XmpProfileList.Add(newCpu);
    }

    public IEnumerable<IXMPProfile> Get()
    {
        return XmpProfileList;
    }
}