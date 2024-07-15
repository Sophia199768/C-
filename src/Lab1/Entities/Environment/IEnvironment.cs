using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public interface IEnvironment
{
    public int ConsumptionRatio { get; }
    public int EnvironmentSize { get; }
    public EnvironmentResult ShipStatus(ISpaceship spaceship);
}