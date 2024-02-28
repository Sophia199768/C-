using System.Collections.Generic;
using ConsoleApp3.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryMotherBoard
{
    public RepositoryMotherBoard()
    {
        MotherboardList.Add(new AsusMotherBoardDirector().Create(new MotherBoardBuilder()).FinishBuild());
    }

    private List<IMotherboard> MotherboardList { get; } = new List<IMotherboard>();

    public void Add(IMotherboard newCpu)
    {
        MotherboardList.Add(newCpu);
    }

    public IEnumerable<IMotherboard> Get()
    {
        return MotherboardList;
    }
}