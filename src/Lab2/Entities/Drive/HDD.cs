namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class Hdd : IDrive
{
    public Hdd(int spindleRotationSpeed, int capacity, double powerConsumptio, int hddCost)
    {
        SpindleRotationSpeed = spindleRotationSpeed;
        Capacity = capacity;
        PowerConsumption = powerConsumptio;
        Cost = hddCost;
    }

    public Hdd()
    {
    }

    public int SpindleRotationSpeed { get; }
    public int Capacity { get; set; }
    public int Cost { get; set; }
    public double PowerConsumption { get; set; }

    public IDriveBuilder Clone()
    {
        return new HddBuilder(new Hdd(SpindleRotationSpeed, Capacity, PowerConsumption, Cost));
    }
}