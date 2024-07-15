namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

public interface IPowerUnitDirector
{
    public PowerUnitBuilder Create(PowerUnitBuilder build);
}