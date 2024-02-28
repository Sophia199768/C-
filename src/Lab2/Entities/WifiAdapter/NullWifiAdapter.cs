namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class NullWifiAdapter : IWifiAdapter
{
    public NullWifiAdapter()
    {
        VersionOfWifi = "null";
        BuiltInBluetoothModule = new Result.HasNotBluetooth();
        VersionOfPCIE = "null";
        PowerConsumption = 0;
    }

    public string VersionOfWifi { get; }
    public Result BuiltInBluetoothModule { get; }
    public string VersionOfPCIE { get; }
    public double PowerConsumption { get; }

    public WifiAdapterBuilder Clone()
    {
        return new WifiAdapterBuilder(new WifiAdapter(
            VersionOfWifi,
            BuiltInBluetoothModule,
            VersionOfPCIE,
            PowerConsumption));
    }
}