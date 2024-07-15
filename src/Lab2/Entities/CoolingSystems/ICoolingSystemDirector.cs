namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public interface ICoolingSystemDirector
{
    public CoolingSystemBuilder Create(CoolingSystemBuilder builder);
}