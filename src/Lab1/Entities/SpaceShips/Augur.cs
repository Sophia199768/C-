using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class Augur : BaseSpaceShip
{
    private const int Photonic = 3;
    private const int NoPhotonic = 0;

    private Augur(int photonicDeflectorHp)
    {
        ShipPulsedEngine = new PulsedPulsedEngineE();
        ShipShield = new Shield(photonicDeflectorHp, new DeflectorClass3());
        Hull = new HullThree();
        ShipJumpEngine = new AlphaJumpEngine();
        Emitter = null;
    }

    public static Augur BuildWithPhotonic()
    {
        return new Augur(Photonic);
    }

    public static Augur BuildWithNoPhotonic()
    {
        return new Augur(NoPhotonic);
    }
}