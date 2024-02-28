using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

public class HullOne : IHull
{
    private const int HullHp = 10;
    private const int NoProtection = 0;
    private const string DefaultMessage = "The spaceship was broken";

    public HullOne()
    {
        ShipHullHp = HullHp;
    }

    public int ShipHullHp { get; set; }

    public HullInfoResult ResidualProtection(IObstacle obstacle)
    {
        ShipHullHp -= obstacle.Destructiveness;

        if (ShipHullHp <= NoProtection)
        {
            return new HullInfoResult.HullWasBroken(DefaultMessage);
        }

        return new HullInfoResult.HullIsNotCrushed(ShipHullHp);
    }
}