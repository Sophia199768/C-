using System.Collections.Generic;
namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public interface ICpu
{
    public string GetSockets { get; }
    public Result VideoCore { get; }
    public int TDP { get; }
    public int PowerConsumption { get; }
    public double FrequencyCores { get; }
    public int AmountOfCores { get; }
    public int Cost { get; }
    public IEnumerable<int> GetSupportedMemoryFrequencies();

    public bool Equals(ICpu cpu);
    public CpuBuilder Clone();
}