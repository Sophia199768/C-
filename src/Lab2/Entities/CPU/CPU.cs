using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class Cpu : ICpu
{
    private Collection<int> _supportedMemoryFrequencies = new Collection<int>();
    public Cpu(string socket, Result videoCore, Collection<int> supportedMemoryFrequencies, int tdp, int powerConsumption, double frequencyСores, int amountOfCores, int intelCorei5Cost)
    {
        GetSockets = socket;
        VideoCore = videoCore;
        _supportedMemoryFrequencies = supportedMemoryFrequencies;
        TDP = tdp;
        PowerConsumption = powerConsumption;
        FrequencyCores = frequencyСores;
        AmountOfCores = amountOfCores;
        Cost = intelCorei5Cost;
    }

    public Cpu()
    {
        GetSockets = string.Empty;
        VideoCore = new Result.NotGPUCore();
    }

    public string GetSockets { get; set; }
    public int Cost { get; set; }
    public Result VideoCore { get; set; }
    public int TDP { get; set; }
    public int PowerConsumption { get; set; }
    public double FrequencyCores { get; set; }
    public int AmountOfCores { get; set; }

    public bool Equals(ICpu cpu)
    {
        if (GetSockets == cpu.GetSockets && VideoCore == cpu.VideoCore && TDP == cpu.TDP &&
            PowerConsumption == cpu.PowerConsumption && FrequencyCores == cpu.FrequencyCores && AmountOfCores == cpu.AmountOfCores)
        {
            return true;
        }

        return false;
    }

    public CpuBuilder Clone()
    {
        return new CpuBuilder(new Cpu(GetSockets, VideoCore, _supportedMemoryFrequencies, TDP, PowerConsumption, FrequencyCores, AmountOfCores, Cost));
    }

    public IEnumerable<int> GetSupportedMemoryFrequencies()
    {
        return _supportedMemoryFrequencies;
    }

    public void SetSupportedMemoryFrequencies(Collection<int> supportedMemoryFrequencies)
    {
        _supportedMemoryFrequencies = supportedMemoryFrequencies;
    }
}