using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public class IntelCorei9Director : ICpuDirector
{
    private string _socket = "LGA1700";
    private Result _videoCore = new Result.NotGPUCore();
    private Collection<int> _supportedMemoryFrequencies = new Collection<int>() { 5600 };
    private int _tdp = 253;
    private int _powerConsumption = 40;
    private double _frequencyСores = 3;
    private int _amountOfCores = 24;
    private int _intelCorei9Cost = 82940;

    public CpuBuilder Create(CpuBuilder build)
    {
        build.SetCost(_intelCorei9Cost);
        build.SetVideoCore(_videoCore);
        build.SetFrequencyСores(_frequencyСores);
        build.SetPowerConsumption(_powerConsumption);
        build.SetAmountOfCores(_amountOfCores);
        build.SetTDP(_tdp);
        build.SetSupportedMemoryFrequencies(_supportedMemoryFrequencies);
        build.SetSockets(_socket);
        return build;
    }
}