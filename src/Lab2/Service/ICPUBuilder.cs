using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface ICPUBuilder
{
    public ICoolingSystemBuilder SetCPU(ICpu cpu);
}