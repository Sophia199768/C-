using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class Bios : IBios
{
    private Collection<ICpu> _processes;
    public Bios(string type, double version, Collection<ICpu> processes, int uefiCost)
    {
        Type = type;
        Version = version;
        _processes = processes;
        Cost = uefiCost;
    }

    public Bios()
    {
        Type = string.Empty;
        _processes = new Collection<ICpu>();
    }

    public string Type { get; set; }
    public int Cost { get; set; }
    public double Version { get; set; }

    public BiosBuilder Clone()
    {
        return new BiosBuilder(new Bios(Type, Version, _processes, Cost));
    }

    public void SetProcess(Collection<ICpu> processors)
    {
        _processes = processors;
    }

    public IEnumerable<ICpu> GetProcessors()
    {
        return _processes;
    }
}