using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class AMIDirector : IBiosDirector
{
    private string _type = "AMI";
    private double _version = 1.1;
    private Collection<ICpu> _processes = new Collection<ICpu>() { new IntelCorei5Director().Create(new CpuBuilder()).FinishBuild() };
    private int _amiCost = 599;
    public BiosBuilder Create(BiosBuilder build)
    {
        build.SetCost(_amiCost);
        build.SetVersion(_version);
        build.SetType(_type);
        build.SetProcesses(_processes);
        return build;
    }
}