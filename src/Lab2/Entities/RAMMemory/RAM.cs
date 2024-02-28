namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class Ram : IRAMMemory
{
    public Ram(
        int amountFreeMemory,
        int frequensyJedec,
        int standartDDR,
        double powerConsuption,
        IXMPProfile xmp,
        string formFactor,
        int cost)
    {
        AmountFreeMemory = amountFreeMemory;
        FrequensyJedec = frequensyJedec;
        StandartDDR = standartDDR;
        PowerConsuption = powerConsuption;
        XMP = xmp;
        FormFactor = formFactor;
        Cost = cost;
    }

    public Ram()
    {
        XMP = new NullXMPProfile();
        FormFactor = string.Empty;
    }

    public int AmountFreeMemory { get; set; }
    public int FrequensyJedec { get; set; }
    public int StandartDDR { get; set; }
    public int Cost { get; set; }
    public double PowerConsuption { get; set; }
    public IXMPProfile XMP { get; set; }
    public string FormFactor { get; set; }

    public RamBuilder Clone()
    {
        return new RamBuilder(new Ram(
            AmountFreeMemory,
            FrequensyJedec,
            StandartDDR,
            PowerConsuption,
            XMP,
            FormFactor,
            Cost));
    }
}