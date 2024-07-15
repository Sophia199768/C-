namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class DeflectorClass1 : BaseDeflector
{
    private const int Class1 = 18;
    private const double DisperationCoefficientSmall = 0.9;
    private const double DisperationCoefficientMedium = 0.8;
    private const int DamageLimitForSmallAmount = 21;
    private const int DamageLimitForBigAmount = 24;

    public DeflectorClass1()
    {
        SmallDisperationCoefficient = DisperationCoefficientSmall;
        MediumDisperationCoefficient = DisperationCoefficientMedium;
        SmallDamageLimit = DamageLimitForSmallAmount;
        BigDamageLimit = DamageLimitForBigAmount;
        ShipDeflectorHp = Class1;
    }
}