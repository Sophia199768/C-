namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class DeflectorClass2 : BaseDeflector
{
    private const int Class2 = 65;
    private const double DisperationCoefficientSmall = 0.95;
    private const double DisperationCoefficientMedium = 0.65;
    private const int DamageLimitForSmallAmount = 70;
    private const int DamageLimitForBigAmount = 101;

    public DeflectorClass2()
    {
        SmallDisperationCoefficient = DisperationCoefficientSmall;
        MediumDisperationCoefficient = DisperationCoefficientMedium;
        SmallDamageLimit = DamageLimitForSmallAmount;
        BigDamageLimit = DamageLimitForBigAmount;
        ShipDeflectorHp = Class2;
    }
}