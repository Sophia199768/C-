using Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface ICoolingSystemBuilder
{
    public IRAMBuilder SetCoolingSystem(ICoolingSystem coolingSystem);
}