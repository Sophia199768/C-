using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class Meridian : BaseSpaceShip
{
    private const int Photonic = 3;
    private const int NoPhotonic = 0;
    private Meridian(int photonicDeflector)
    {
        ShipPulsedEngine = new PulsedPulsedEngineC();
        ShipShield = new Shield(photonicDeflector, new DeflectorClass2());
        Hull = new HullTwo();
        ShipJumpEngine = new NullJumpEngine();
        Emitter = new AntiNitrineЕmitter();
    }

    public static Meridian BuildWithPhotonic()
    {
        return new Meridian(Photonic);
    }

    public static Meridian BuildWithNoPhotonic()
    {
        return new Meridian(NoPhotonic);
    }
}
