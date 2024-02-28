namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public interface IXMPProfile
{
    public string Timing { get; }
    public double Voltage { get; }
    public int Frequency { get; }
    public XmpProfileBuilder Clone();
}