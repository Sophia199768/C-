using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public static class ValidatorDisclaimerOfWarranties
{
    private const string BoundaryPowerOfPowerUnit =
        "Disclaimer of warranty, since the power of the power supply is less than recommended.";
    private const string ProductiveProcessorAndWeakCoolingSystem = "A productive processor is installed a weak cooling system.";
    private const double PowerCoefficent = 1.1;

    public static Result DisclaimerOfWarranties(Computer computer)
    {
        if (computer.Cpu.PowerConsumption + computer.VideoCard.PowerConsumption + computer.Drive.PowerConsumption <
            computer.PowerUnit.PeakLoad * PowerCoefficent &&
            computer.Cpu.PowerConsumption + computer.VideoCard.PowerConsumption + computer.Drive.PowerConsumption >
            computer.PowerUnit.PeakLoad)
        {
            return new Result.DisclaimerOfWarranty(BoundaryPowerOfPowerUnit);
        }

        if (computer.CoolingSystem.TDP < computer.Cpu.TDP)
        {
            return new Result.DisclaimerOfWarranty(ProductiveProcessorAndWeakCoolingSystem);
        }

        return new Result.SuccessfulBuild();
    }
}