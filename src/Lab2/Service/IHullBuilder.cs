using Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IHullBuilder
{
    public IPowerUnitBuilder SetHull(IHull hull);
}