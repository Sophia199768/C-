using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryDrive
{
    public RepositoryDrive()
    {
        DriveList.Add(new HddFactory().Create());
        DriveList.Add(new SsdFactory().Create());
    }

    private List<IDrive> DriveList { get; } = new List<IDrive>();

    public void Add(IDrive newCpu)
    {
        DriveList.Add(newCpu);
    }

    public IEnumerable<IDrive> Get()
    {
        return DriveList;
    }
}