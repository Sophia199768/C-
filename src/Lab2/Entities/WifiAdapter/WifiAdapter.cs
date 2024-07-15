namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class WifiAdapter : IWifiAdapter
{
    public WifiAdapter(string versionOfWifi, Result builtInBluetoothModule, string versionOfPcie, double powerConsumption)
    {
        VersionOfWifi = versionOfWifi;
        BuiltInBluetoothModule = builtInBluetoothModule;
        VersionOfPCIE = versionOfPcie;
        PowerConsumption = powerConsumption;
    }

    public WifiAdapter()
    {
        BuiltInBluetoothModule = new Result.HasNotBluetooth();
        VersionOfPCIE = string.Empty;
        VersionOfWifi = string.Empty;
    }

    public string VersionOfWifi { get; set; }
    public Result BuiltInBluetoothModule { get; set; }
    public string VersionOfPCIE { get; set; }
    public double PowerConsumption { get; set; }

    public WifiAdapterBuilder Clone()
    {
        return new WifiAdapterBuilder(new WifiAdapter(
            VersionOfWifi,
            BuiltInBluetoothModule,
            VersionOfPCIE,
            PowerConsumption));
    }
}