using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class UEFIFactory : IBiosDirector
{
    private string _type = "UEFI";
    private double _version = 3.2;
    private Collection<ICpu> _processes = new Collection<ICpu>() { new IntelCorei5Director().Create(new CpuBuilder()).FinishBuild(), new IntelCorei9Director().Create(new CpuBuilder()).FinishBuild() };
    private int _uefiCost = 329;
    public BiosBuilder Create(BiosBuilder build)
    {
        build.SetCost(_uefiCost);
        build.SetVersion(_version);
        build.SetType(_type);
        build.SetProcesses(_processes);
        return build;
    }
}