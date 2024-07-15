using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public class AwardDirector : IBiosDirector
{
    private string _type = "AWARD";
    private double _version = 2.3;
    private Collection<ICpu> _processes = new Collection<ICpu>() { new IntelCorei5Director().Create(new CpuBuilder()).FinishBuild(), new IntelCorei7Director().Create(new CpuBuilder()).FinishBuild() };
    private int _awardCost = 750;
    public BiosBuilder Create(BiosBuilder build)
    {
        build.SetCost(_awardCost);
        build.SetVersion(_version);
        build.SetType(_type);
        build.SetProcesses(_processes);
        return build;
    }
}