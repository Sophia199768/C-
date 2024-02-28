using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class BiosBuilder
{
    public BiosBuilder(Bios computerBios) => ComputerBios = computerBios;
    public BiosBuilder() => ComputerBios = new Bios();
    public Bios ComputerBios { get; private set; }

    public BiosBuilder SetType(string type)
    {
        ComputerBios.Type = type;
        return this;
    }

    public BiosBuilder SetVersion(double version)
    {
        ComputerBios.Version = version;
        return this;
    }

    public BiosBuilder SetCost(int cost)
    {
        ComputerBios.Cost = cost;
        return this;
    }

    public BiosBuilder SetProcesses(Collection<ICpu> processors)
    {
        ComputerBios.SetProcess(processors);
        return this;
    }

    public IBios FinishBuild()
    {
        return ComputerBios;
    }
}