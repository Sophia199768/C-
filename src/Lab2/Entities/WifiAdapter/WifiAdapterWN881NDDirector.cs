namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class WifiAdapterWN881NDDirector : IWifiAdapterDirector
{
    private string _versionOfWifi = "N300";
    private string _versionOfPcie = "1.0";
    private double _powerConsumption = 15;
    public WifiAdapterBuilder Create(WifiAdapterBuilder builder)
    {
        Result builtInBluetooth = new Result.HasNotBluetooth();
        builder.SetPowerConsumption(_powerConsumption);
        builder.SetVersionOfWifi(_versionOfWifi);
        builder.SetBuiltInBluetoothModule(builtInBluetooth);
        builder.SetVersionOfPCIE(_versionOfPcie);
        return builder;
    }
}