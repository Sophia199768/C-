using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class IntelCorei7Director : ICpuDirector
{
    private string _sockets = "LGA1700";
    private Result _videoCore = new Result.HasGPUCore();
    private Collection<int> _supportedMemoryFrequencies = new Collection<int>() { 3200, 5600 };
    private double _frequencyСores = 3.4;
    private int _tdp = 125;
    private int _powerConsumption = 256;
    private int _amountOfCores = 16;
    private int _intelCorei7Cost = 36990;

    public CpuBuilder Create(CpuBuilder build)
    {
        build.SetCost(_intelCorei7Cost);
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