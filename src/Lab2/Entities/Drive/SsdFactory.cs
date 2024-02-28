namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

public class SsdFactory
{
    private Result _connectionOption = new Result.ConnectionOptionSATA();
    private int _maximumOperatingSpeed = 500;
    private int _capacity = 480;
    private double _powerConsumption = 1.535;
    private int _ssdCost = 3700;

    public IDrive Create()
    {
        return new Ssd(_connectionOption, _maximumOperatingSpeed, _capacity, _powerConsumption, _ssdCost);
    }
}