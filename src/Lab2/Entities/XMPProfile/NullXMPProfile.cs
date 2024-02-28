namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class NullXMPProfile : IXMPProfile
{
    public NullXMPProfile()
    {
        Timing = "null";
        Voltage = 0;
        Frequency = 0;
    }

    public string Timing { get; }
    public double Voltage { get; }
    public int Frequency { get; }

    public XmpProfileBuilder Clone()
    {
        return new XmpProfileBuilder(new Xmp(
            Timing,
            Voltage,
            Frequency));
    }
}