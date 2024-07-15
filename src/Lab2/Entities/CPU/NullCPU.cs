using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class NullCpu : ICpu
{
    private const int NullCPUCost = 0;
    private const int CPUtdp = 0;
    private const int CPUPowerConsumption = 0;
    private const int CPUFrequencyСores = 0;
    private const int CPUAmountOfCores = 0;
    private Collection<int> _supportedMemoryFrequencies = new Collection<int>();
    public NullCpu()
    {
        GetSockets = "null";
        VideoCore = new Result.NotGPUCore();
        _supportedMemoryFrequencies = new Collection<int>();
        TDP = CPUtdp;
        PowerConsumption = CPUPowerConsumption;
        FrequencyCores = CPUFrequencyСores;
        AmountOfCores = CPUAmountOfCores;
        Cost = NullCPUCost;
    }

    public string GetSockets { get; }
    public Result VideoCore { get; }
    public int TDP { get; }
    public int PowerConsumption { get; }
    public int Cost { get; }
    public double FrequencyCores { get; }
    public int AmountOfCores { get; }
    public IEnumerable<int> GetSupportedMemoryFrequencies()
    {
        return _supportedMemoryFrequencies;
    }

    public bool Equals(ICpu cpu)
    {
        return false;
    }

    public CpuBuilder Clone()
    {
        return new CpuBuilder(new Cpu(GetSockets, VideoCore, _supportedMemoryFrequencies, TDP, PowerConsumption, FrequencyCores, AmountOfCores, Cost));
    }
}