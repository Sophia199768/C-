namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class HddFactory
{
    private int _spindleRotationSpeed = 7200;
    private int _capacity = 2048;
    private double _powerConsumption = 5.1;
    private int _hddCost = 6690;

    public IDrive Create()
    {
        return new Hdd(_spindleRotationSpeed, _capacity, _powerConsumption, _hddCost);
    }
}