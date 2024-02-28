namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class HddBuilder : IDriveBuilder
{
    public HddBuilder(Hdd hdd) => ComputerHdd = hdd;
    public HddBuilder() => ComputerHdd = new Hdd();
    public Hdd ComputerHdd { get; }
    public HddBuilder SetCapacity(int capacity)
    {
        ComputerHdd.Capacity = capacity;
        return this;
    }

    public HddBuilder SetPowerConsumption(int powerConsumption)
    {
        ComputerHdd.PowerConsumption = powerConsumption;
        return this;
    }

    public HddBuilder SetCost(int cost)
    {
        ComputerHdd.Cost = cost;
        return this;
    }

    public IDrive FinishBuild()
    {
        return ComputerHdd;
    }
}