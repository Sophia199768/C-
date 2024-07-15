using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;
public interface ISpaceship
{
    public IJumpEngine ShipJumpEngine { get; }
    public IPulsedEngine ShipPulsedEngine { get; }
    public IHull Hull { get; }
    public AntiNitrineЕmitter? Emitter { get; }
    public Shield ShipShield { get; }
    public HullInfoResult PresenceOfPhotonicDeflector(IObstacle obstacle);
}