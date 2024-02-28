namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public interface IHullDirector
{
    public HullBuilder Create(HullBuilder build);
}