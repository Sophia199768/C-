namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class RamBuilder
{
    public RamBuilder(Ram ram) => ComputerRam = ram;
    public RamBuilder() => ComputerRam = new Ram();
    public Ram ComputerRam { get; }
    public RamBuilder SetAmountFreeMemory(int amount)
    {
        ComputerRam.AmountFreeMemory = amount;
        return this;
    }

    public RamBuilder SetFrequensyJedec(int frequencyJedec)
    {
        ComputerRam.FrequensyJedec = frequencyJedec;
        return this;
    }

    public RamBuilder SetXMP(IXMPProfile xmp)
    {
        ComputerRam.XMP = xmp;
        return this;
    }

    public RamBuilder SetFormFactor(string formFactor)
    {
        ComputerRam.FormFactor = formFactor;
        return this;
    }

    public RamBuilder SetStandartDDR(int ddr)
    {
        ComputerRam.StandartDDR = ddr;
        return this;
    }

    public RamBuilder SetCost(int cost)
    {
        ComputerRam.Cost = cost;
        return this;
    }

    public RamBuilder SetPowerConsuption(double consumption)
    {
        ComputerRam.PowerConsuption = consumption;
        return this;
    }

    public IRAMMemory FinishBuild()
    {
        return ComputerRam;
    }
}