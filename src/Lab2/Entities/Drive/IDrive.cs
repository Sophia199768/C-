namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public interface IDrive
{
    public double PowerConsumption { get; }
    public int Cost { get; }
    public IDriveBuilder Clone();
}