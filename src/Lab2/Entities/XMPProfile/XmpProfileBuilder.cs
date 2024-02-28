namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class XmpProfileBuilder
{
    public XmpProfileBuilder(Xmp xmp) => ComputerXmp = xmp;
    public XmpProfileBuilder() => ComputerXmp = new Xmp();
    public Xmp ComputerXmp { get; }

    public XmpProfileBuilder SetTiming(string timing)
    {
        ComputerXmp.Timing = timing;
        return this;
    }

    public XmpProfileBuilder SetVoltage(double voltage)
    {
        ComputerXmp.Voltage = voltage;
        return this;
    }

    public XmpProfileBuilder SetFrequency(int frequency)
    {
        ComputerXmp.Frequency = frequency;
        return this;
    }

    public IXMPProfile FinishBuild()
    {
        return ComputerXmp;
    }
}