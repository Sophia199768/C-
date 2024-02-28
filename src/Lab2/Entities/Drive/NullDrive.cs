namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class NullDrive : IDrive
{
    private const int NullDriveCost = 0;
    private const int DriveSpindleRotationSpeed = 0;
    private const int DriveCapacity = 0;
    private const int DrivePowerConsumption = 0;
    public NullDrive()
    {
        SpindleRotationSpeed = DriveSpindleRotationSpeed;
        Capacity = DriveCapacity;
        PowerConsumption = DrivePowerConsumption;
        Cost = NullDriveCost;
    }

    public int SpindleRotationSpeed { get; }
    public int Capacity { get; }
    public int Cost { get; }
    public double PowerConsumption { get; }

    public IDriveBuilder Clone()
    {
        return new HddBuilder(new Hdd(SpindleRotationSpeed, Capacity, PowerConsumption, Cost));
    }
}