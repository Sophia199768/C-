namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class NullDeflectors : BaseDeflector
{
    private const int Class0 = 0;
    private const double DisperationCoefficientSmall = 1;
    private const double DisperationCoefficientMedium = 1;
    private const int DamageLimitForSmallAmount = 1;
    private const int DamageLimitForBigAmount = 1;

    public NullDeflectors()
    {
        SmallDisperationCoefficient = DisperationCoefficientSmall;
        MediumDisperationCoefficient = DisperationCoefficientMedium;
        SmallDamageLimit = DamageLimitForSmallAmount;
        BigDamageLimit = DamageLimitForBigAmount;
        ShipDeflectorHp = Class0;
    }
}