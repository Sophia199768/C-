using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class Vaclas : BaseSpaceShip
{
    private const int Photonic = 3;
    private const int NoPhotonic = 0;

    private Vaclas(int photonicDeflector)
    {
        ShipPulsedEngine = new PulsedPulsedEngineE();
        ShipShield = new Shield(photonicDeflector, new DeflectorClass2());
        Hull = new HullOne();
        ShipJumpEngine = new GammaJumpEngine();
        Emitter = null;
    }

    public static Vaclas BuildWithPhotonic()
    {
        return new Vaclas(Photonic);
    }

    public static Vaclas BuildWithNoPhotonic()
    {
        return new Vaclas(NoPhotonic);
    }
}