using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Hull;

public class HullTwo : IHull
{
    private const int HullHP = 40;
    private const int NoProtection = 0;
    private const string DefaultMessage = "The spaceship was broken";
    private const double SmallDisperationCoefficient = 0.87;
    private const double MediumDisperationCoefficient = 0.8;
    private const double NoDispertionCoefficent = 1;
    private const int SmallDamageLimit = 47;
    private const int BigDamageLimit = 51;

    public HullTwo()
    {
        ShipHullHP = HullHP;
    }

    public int ShipHullHP { get; set; }

    public HullInfoResult ResidualProtection(IObstacle obstacle)
    {
        double dispersionCoefficient = NoDispertionCoefficent;

        if (obstacle.Destructiveness < SmallDamageLimit)
        {
            dispersionCoefficient = MediumDisperationCoefficient;
        }
        else if (obstacle.Destructiveness < BigDamageLimit)
        {
            dispersionCoefficient = SmallDisperationCoefficient;
        }

        ShipHullHP -= (int)(dispersionCoefficient * obstacle.Destructiveness);

        if (ShipHullHP <= NoProtection)
        {
            return new HullInfoResult.HullWasBroken(DefaultMessage);
        }

        return new HullInfoResult.HullIsNotCrushed(ShipHullHP);
    }
}