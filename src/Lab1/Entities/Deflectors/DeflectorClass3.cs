namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class DeflectorClass3 : BaseDeflector
{
    private const int Class3 = 200;
    private const double DisperationCoefficientSmall = 0.5;
    private const double DisperationCoefficientMedium = 0.87;
    private const int DamageLimitForSmallAmount = 231;
    private const int DamageLimitForBigAmount = 401;

    public DeflectorClass3()
    {
        SmallDisperationCoefficient = DisperationCoefficientSmall;
        MediumDisperationCoefficient = DisperationCoefficientMedium;
        SmallDamageLimit = DamageLimitForSmallAmount;
        BigDamageLimit = DamageLimitForBigAmount;
        ShipDeflectorHp = Class3;
    }
}