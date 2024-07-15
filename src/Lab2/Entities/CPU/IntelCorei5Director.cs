using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class IntelCorei5Director : ICpuDirector
{
    private string _sockets = "LGA1700";
    private Result _videoCore = new Result.HasGPUCore();
    private Collection<int> _supportedMemoryFrequencies = new Collection<int>() { 4800, 3200 };
    private double _frequencyСores = 2.5;
    private int _tdp = 65;
    private int _powerConsumption = 120;
    private int _amountOfCores = 10;
    private int _intelCorei5Cost = 18890;

    public CpuBuilder Create(CpuBuilder build)
    {
        build.SetCost(_intelCorei5Cost);
        build.SetVideoCore(_videoCore);
        build.SetFrequencyСores(_frequencyСores);
        build.SetPowerConsumption(_powerConsumption);
        build.SetAmountOfCores(_amountOfCores);
        build.SetTDP(_tdp);
        build.SetSupportedMemoryFrequencies(_supportedMemoryFrequencies);
        build.SetSockets(_sockets);
        return build;
    }
}