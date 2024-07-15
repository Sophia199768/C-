namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public class VideoCard : IVideoCard
{
    public VideoCard(
        int heightVideoCard,
        int weightVideoCard,
        int amountOfMemory,
        double pcie,
        int chipFrequency,
        double powerConsumption,
        int cost)
    {
        HeightVideoCard = heightVideoCard;
        WeightVideoCard = weightVideoCard;
        AmountOfMemory = amountOfMemory;
        PCIE = pcie;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
        Cost = cost;
    }

    public VideoCard() { }

    public int HeightVideoCard { get; set; }
    public int WeightVideoCard { get; set; }
    public int AmountOfMemory { get; set; }
    public int Cost { get; set; }
    public double PCIE { get; set; }
    public int ChipFrequency { get; set; }
    public double PowerConsumption { get; set; }

    public VideoCardBuilder Clone()
    {
        return new VideoCardBuilder(new VideoCard(
            HeightVideoCard,
            WeightVideoCard,
            AmountOfMemory,
            PCIE,
            ChipFrequency,
            PowerConsumption,
            Cost));
    }
}