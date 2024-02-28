using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class PleasureShuttle : BaseSpaceShip
{
    private const int Photonic = 3;
    private const int NoPhotonic = 0;

    public PleasureShuttle(int photonicDeflector)
    {
        ShipPulsedEngine = new PulsedPulsedEngineC();
        ShipShield = new Shield(photonicDeflector, new NullDeflectors());
        Hull = new HullOne();
        ShipJumpEngine = new NullJumpEngine();
        Emitter = null;
    }

    public static PleasureShuttle BuildWithPhotonic()
    {
        return new PleasureShuttle(Photonic);
    }

    public static PleasureShuttle BuildWithNoPhotonic()
    {
        return new PleasureShuttle(NoPhotonic);
    }
}