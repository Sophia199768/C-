using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class BaseSpaceShip : ISpaceship
{
    private const int NoPhotonic = 0;
    public Shield ShipShield { get; set; } = new Shield(NoPhotonic, new NullDeflectors());
    public IHull Hull { get; set; } = new HullOne();
    public AntiNitrineЕmitter? Emitter { get; set; }
    public IJumpEngine ShipJumpEngine { get; set; } = new NullJumpEngine();
    public IPulsedEngine ShipPulsedEngine { get; set; } = new PulsedPulsedEngineC();

    public HullInfoResult PresenceOfPhotonicDeflector(IObstacle obstacle)
    {
        return ShipShield.ResidualPhotonicProtection(obstacle);
    }
}