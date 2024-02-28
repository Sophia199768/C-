using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class Stella : BaseSpaceShip
{
    private const int Photonic = 3;
    private const int NoPhotonic = 0;

    private Stella(int photonicDeflector)
    {
        ShipPulsedEngine = new PulsedPulsedEngineC();
        ShipShield = new Shield(photonicDeflector, new DeflectorClass1());
        Hull = new HullOne();
        ShipJumpEngine = new OmegaJumpEngine();
        Emitter = null;
    }

    public static Stella BuildWithPhotonic()
    {
        return new Stella(Photonic);
    }

    public static Stella BuildWithNoPhotonic()
    {
        return new Stella(NoPhotonic);
    }
}