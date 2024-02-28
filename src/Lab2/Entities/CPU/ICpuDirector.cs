namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

public interface ICpuDirector
{
    public CpuBuilder Create(CpuBuilder build);
}