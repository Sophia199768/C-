namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class KingstoneIxmpDirector : IXmpDirector
{
    private string _timing = "40-40-40-77";
    private double _voltage = 1.25;
    private int _frequency = 4800;

    public XmpProfileBuilder Create(XmpProfileBuilder builder)
    {
        builder.SetFrequency(_frequency);
        builder.SetTiming(_timing);
        builder.SetVoltage(_voltage);
        return builder;
    }
}