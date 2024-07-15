using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
public interface IDeflector
{
    public HullInfoResult ResidualProtection(IObstacle obstacle);
}