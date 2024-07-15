namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public class KingstoneIramDirectors : IRamDirector
{
    private int _aountFreeMemory = 16;
    private int _frequensyJedec = 3300;
    private int _standartDDR = 4;
    private int _cost = 6290;
    private double _powerConsuption = 1.2;
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