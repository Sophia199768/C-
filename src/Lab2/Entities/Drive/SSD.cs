namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class Ssd : IDrive
{
    public Ssd(Result connectionOption, int maximumOperatingSpeed, int capacity, double powerConsumption, int ssdCost)
    {
        ConnectionOption = connectionOption;
        MaximumOperatingSpeed = maximumOperatingSpeed;
        Capacity = capacity;
        PowerConsumption = powerConsumption;
        Cost = ssdCost;
    }

    public Ssd()
    {
        ConnectionOption = new Result.ConnectionOptionPCIE();
    }

    public Result ConnectionOption { get; set; }
    public int MaximumOperatingSpeed { get; set; }
    public int Capacity { get; set; }
    public int Cost { get; set; }
    public double PowerConsumption { get; set; }

    public IDriveBuilder Clone()
    {
        return new SsdBuilder(new Ssd(ConnectionOption, MaximumOperatingSpeed, Capacity, PowerConsumption, Cost));
    }
}