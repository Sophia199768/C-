namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class NullRAM : IRAMMemory
{
    public NullRAM()
    {
        AmountFreeMemory = 0;
        FrequensyJedec = 0;
        StandartDDR = 0;
        PowerConsuption = 0;
        Cost = 0;
        XMP = new NullXMPProfile();
        FormFactor = "null";
    }

    public int AmountFreeMemory { get; }
    public int FrequensyJedec { get; }
    public int StandartDDR { get; }
    public int Cost { get; }
    public double PowerConsuption { get; }
    public IXMPProfile XMP { get; }
    public string FormFactor { get; }

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