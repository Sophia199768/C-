namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class SsdBuilder : IDriveBuilder
{
    public SsdBuilder(Ssd ssd) => ComputerSsd = ssd;
    public SsdBuilder() => ComputerSsd = new Ssd();
    public Ssd ComputerSsd { get; }
    public SsdBuilder SetCapacity(int capacity)
    {
        ComputerSsd.Capacity = capacity;
        return this;
    }

    public SsdBuilder SetPowerConsumption(int powerConsumption)
    {
        ComputerSsd.PowerConsumption = powerConsumption;
        return this;
    }

    public SsdBuilder SetCost(int cost)
    {
        ComputerSsd.Cost = cost;
        return this;
    }

    public SsdBuilder SetMaximumOperatingSpeed(int maximumOperatingSpeed)
    {
        ComputerSsd.MaximumOperatingSpeed = maximumOperatingSpeed;
        return this;
    }

    public SsdBuilder SetConnectionOption(Result connectionOption)
    {
        ComputerSsd.ConnectionOption = connectionOption;
        return this;
    }

    public IDrive FinishBuild()
    {
        return ComputerSsd;
    }
}