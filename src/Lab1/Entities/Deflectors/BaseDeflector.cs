using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class BaseDeflector : IDeflector
{
    private const int NoProtection = 0;
    private const double NoDispertionCoefficent = 1;
    public int ShipDeflectorHp { get; protected set; }
    public double SmallDisperationCoefficient { get; protected init; }
    public double MediumDisperationCoefficient { get; protected set; }
    public int SmallDamageLimit { get; protected set; }
    public int BigDamageLimit { get; protected set; }

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

        ShipDeflectorHp -= (int)(dispersionCoefficient * obstacle.Destructiveness);

        if (ShipDeflectorHp <= NoProtection)
        {
            return new HullInfoResult.Fragments(new Fragments(-ShipDeflectorHp), NoProtection);
        }

        return new HullInfoResult.Fragments(new Fragments(), ShipDeflectorHp);
    }
}
