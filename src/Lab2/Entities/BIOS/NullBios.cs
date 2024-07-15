using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class NullBios : IBios
{
    private const int NullCost = 0;
    private const int NullVersion = 0;
    public NullBios()
    {
        Type = "null";
        Version = NullVersion;
        Processes = new Collection<ICpu>();
        Cost = NullCost;
    }

    public string Type { get; }
    public int Cost { get; }
    public double Version { get; }
    public Collection<ICpu> Processes { get; }

    public BiosBuilder Clone()
    {
        return new BiosBuilder(new Bios(Type, Version, Processes, Cost));
    }

    public IEnumerable<ICpu> GetProcessors()
    {
        return Processes;
    }
}