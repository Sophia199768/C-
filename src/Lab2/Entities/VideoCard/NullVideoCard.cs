namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public class NullVideoCard : IVideoCard
{
    public NullVideoCard()
    {
        HeightVideoCard = 0;
        WeightVideoCard = 0;
        AmountOfMemory = 0;
        PCIE = 0;
        ChipFrequency = 0;
        PowerConsumption = 0;
        Cost = 0;
    }

    public int HeightVideoCard { get; }
    public int WeightVideoCard { get; }
    public int AmountOfMemory { get; }
    public int Cost { get; }
    public double PCIE { get; }
    public int ChipFrequency { get; }
    public double PowerConsumption { get; }

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