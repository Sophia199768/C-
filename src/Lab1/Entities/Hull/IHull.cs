using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

public interface IHull
{
    public HullInfoResult ResidualProtection(IObstacle obstacle);
}