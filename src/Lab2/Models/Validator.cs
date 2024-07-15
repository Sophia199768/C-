using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public static class Validator
{
    private const string IncompatibilityCPUAndMotherboardSockets = "Incompatibility of CPU and motherboard sockets.";
    private const string IncompatibilityBIOSAndCPU = "Incompatibility of CPU and motherboard BIOS.";
    private const string IncompatibilityCoolingSystemAndMotherboardSockets = "Incompatibilty of Coolingsystem and motherboard sokets.";
    private const string CoolingSystemNotAbleToCool = "The cooling system is not able to cool the processor.";
    private const string IncompatibleFrequencies = "incompatible frequencies.";
    private const string NoNecessaryComponents = "There are no necessary components. You should add videocard or take another CPU";
    private const string NoNecessaryDrive = "There no necessary drive.";
    private const string DimensionsNotCompatible = "Dimensions are not compatible.";
    private const string IncompatibilityFormFactor = "Incompatibility of formfactors";
    private const string InsufficientPowerUnit = "Insufficient power unit";
    private const double PowerCoefficent = 1.1;
    private const double CoolingCoefficent = 1.15;

    public static Result AssemblyValidation(Computer computer)
    {
        ICpu? nessasaryProsess = null;

        if (computer.Motherboard.Socket != computer.Cpu.GetSockets)
        {
            return new Result.FailBuilder(IncompatibilityCPUAndMotherboardSockets);
        }

        foreach (ICpu process in computer.Motherboard.Bios.GetProcessors())
        {
            if (process.Equals(computer.Cpu))
            {
                nessasaryProsess = process;
            }
        }

        if (nessasaryProsess == null)
        {
            return new Result.FailBuilder(IncompatibilityBIOSAndCPU);
        }

        if (computer.CoolingSystem.GetSokets().All(obj => computer.Motherboard.Socket != obj))
        {
            return new Result.FailBuilder(IncompatibilityCoolingSystemAndMotherboardSockets);
        }

        if (computer.Cpu.TDP > computer.CoolingSystem.TDP * CoolingCoefficent)
        {
            return new Result.FailBuilder(CoolingSystemNotAbleToCool);
        }

        if (computer.Cpu.GetSupportedMemoryFrequencies().All(obj => computer.RAM.FrequensyJedec < obj))
        {
            return new Result.FailBuilder(IncompatibleFrequencies);
        }

        if (computer.Cpu.VideoCore is Result.NotGPUCore && computer.VideoCard is NullVideoCard)
        {
            return new Result.FailBuilder(NoNecessaryComponents);
        }

        if (computer.Drive is null)
        {
            return new Result.FailBuilder(NoNecessaryDrive);
        }

        if (computer.Hull.MaxLengthGPU < computer.VideoCard.HeightVideoCard &&
            computer.Hull.MaxWidthGPU < computer.VideoCard.WeightVideoCard)
        {
            return new Result.FailBuilder(DimensionsNotCompatible);
        }

        if (computer.Motherboard.FormFactor != computer.Hull.FormFactorMotherboard)
        {
            return new Result.FailBuilder(IncompatibilityFormFactor);
        }

        if (computer.Cpu.PowerConsumption + computer.VideoCard.PowerConsumption + computer.Drive.PowerConsumption >
            computer.PowerUnit.PeakLoad * PowerCoefficent)
        {
            return new Result.FailBuilder(InsufficientPowerUnit);
        }

        return new Result.SuccessfulBuild();
    }
}