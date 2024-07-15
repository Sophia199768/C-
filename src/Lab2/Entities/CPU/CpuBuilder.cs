using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class CpuBuilder
{
    public CpuBuilder(Cpu computerCpu) => ComputerCpu = computerCpu;
    public CpuBuilder() => ComputerCpu = new Cpu();
    public Cpu ComputerCpu { get; }

    public CpuBuilder SetVideoCore(Result videoCore)
    {
        ComputerCpu.VideoCore = videoCore;
        return this;
    }

    public CpuBuilder SetSupportedMemoryFrequencies(Collection<int> supportedMemoryFrequencies)
    {
        ComputerCpu.SetSupportedMemoryFrequencies(supportedMemoryFrequencies);
        return this;
    }

    public CpuBuilder SetTDP(int tdp)
    {
        ComputerCpu.TDP = tdp;
        return this;
    }

    public CpuBuilder SetCost(int cost)
    {
        ComputerCpu.Cost = cost;
        return this;
    }

    public CpuBuilder SetPowerConsumption(int powerConsumption)
    {
        ComputerCpu.PowerConsumption = powerConsumption;
        return this;
    }

    public CpuBuilder SetFrequencyСores(double frequencyCores)
    {
        ComputerCpu.FrequencyCores = frequencyCores;
        return this;
    }

    public CpuBuilder SetAmountOfCores(int amountOfCores)
    {
        ComputerCpu.AmountOfCores = amountOfCores;
        return this;
    }

    public CpuBuilder SetSockets(string sockets)
    {
        ComputerCpu.GetSockets = sockets;
        return this;
    }

    public ICpu FinishBuild()
    {
        return ComputerCpu;
    }
}