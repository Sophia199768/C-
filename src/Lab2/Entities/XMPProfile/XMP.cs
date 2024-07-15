namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class Xmp : IXMPProfile
{
    public Xmp(string timing, double voltage, int frequency)
    {
        Timing = timing;
        Voltage = voltage;
        Frequency = frequency;
    }

    public Xmp() => Timing = string.Empty;

    public string Timing { get; set; }
    public double Voltage { get; set; }
    public int Frequency { get; set; }

    public XmpProfileBuilder Clone()
    {
        return new XmpProfileBuilder(new Xmp(
            Timing,
            Voltage,
            Frequency));
    }
}