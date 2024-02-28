namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public class Rtx3060TiDirector : IVideoCardDirector
{
    private int _heightVideoCard = 120;
    private int _weightVideoCard = 40;
    private int _amountOfMemory = 8;
    private int _cost = 51265;
    private double _pcie = 4.0;
    private int _chipFrequency = 14000;
    private double _powerConsumption = 200;

    public VideoCardBuilder Create(VideoCardBuilder builder)
    {
        builder.SetHeightVideoCard(_heightVideoCard);
        builder.SetWeightVideoCard(_weightVideoCard);
        builder.SetAmountOfMemory(_amountOfMemory);
        builder.SetPcie(_pcie);
        builder.SetChipFrequency(_chipFrequency);
        builder.SetPowerConsumption(_powerConsumption);
        builder.SetCost(_cost);
        return builder;
    }
}