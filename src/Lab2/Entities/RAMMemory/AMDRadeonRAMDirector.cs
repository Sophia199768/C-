namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class AMDRadeonRAMDirector : IRamDirector
{
    private int _aountFreeMemory = 16;
    private int _frequensyJedec = 5600;
    private int _standartDDR = 5;
    private int _cost = 8300;
    private double _powerConsuption = 1.5;
    private IXMPProfile _xmp = new KingstoneIxmpDirector().Create(new XmpProfileBuilder()).FinishBuild();
    private string _formFactor = "DIMM";

    public RamBuilder Create(RamBuilder builder)
    {
        builder.SetCost(_cost);
        builder.SetPowerConsuption(_powerConsuption);
        builder.SetFormFactor(_formFactor);
        builder.SetFrequensyJedec(_frequensyJedec);
        builder.SetXMP(_xmp);
        builder.SetStandartDDR(_standartDDR);
        builder.SetAmountFreeMemory(_aountFreeMemory);
        return builder;
    }
}