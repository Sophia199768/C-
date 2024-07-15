namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public class VideoCardBuilder
{
    public VideoCardBuilder(VideoCard videoCard) => ComputerVideoCard = videoCard;
    public VideoCardBuilder() => ComputerVideoCard = new VideoCard();
    public VideoCard ComputerVideoCard { get; }
    public VideoCardBuilder SetHeightVideoCard(int heightVideoCard)
    {
        ComputerVideoCard.HeightVideoCard = heightVideoCard;
        return this;
    }

    public VideoCardBuilder SetWeightVideoCard(int weightVideoCard)
    {
        ComputerVideoCard.WeightVideoCard = weightVideoCard;
        return this;
    }

    public VideoCardBuilder SetAmountOfMemory(int amountOfMemory)
    {
        ComputerVideoCard.AmountOfMemory = amountOfMemory;
        return this;
    }

    public VideoCardBuilder SetCost(int cost)
    {
        ComputerVideoCard.Cost = cost;
        return this;
    }

    public VideoCardBuilder SetPcie(double pCIE)
    {
        ComputerVideoCard.PCIE = pCIE;
        return this;
    }

    public VideoCardBuilder SetChipFrequency(int chipFrequency)
    {
        ComputerVideoCard.ChipFrequency = chipFrequency;
        return this;
    }

    public VideoCardBuilder SetPowerConsumption(double powerConsumption)
    {
        ComputerVideoCard.PowerConsumption = powerConsumption;
        return this;
    }

    public IVideoCard FinishBuild()
    {
        return ComputerVideoCard;
    }
}