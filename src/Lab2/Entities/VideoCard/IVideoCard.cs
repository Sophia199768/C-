namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public interface IVideoCard
{
    public int HeightVideoCard { get; }
    public int WeightVideoCard { get; }
    public int AmountOfMemory { get; }
    public int Cost { get; }
    public double PCIE { get; }
    public int ChipFrequency { get; }
    public double PowerConsumption { get; }
    public VideoCardBuilder Clone();
}