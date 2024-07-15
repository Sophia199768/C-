namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class WifiAdapterBuilder
{
    public WifiAdapterBuilder(WifiAdapter wifiAdapter) => ComputerWifiAdapter = wifiAdapter;
    public WifiAdapterBuilder() => ComputerWifiAdapter = new WifiAdapter();
    public WifiAdapter ComputerWifiAdapter { get; }
    public WifiAdapterBuilder SetVersionOfWifi(string versionOfWifi)
    {
        ComputerWifiAdapter.VersionOfWifi = versionOfWifi;
        return this;
    }

    public WifiAdapterBuilder SetBuiltInBluetoothModule(Result builtInBluetoothModule)
    {
        ComputerWifiAdapter.BuiltInBluetoothModule = builtInBluetoothModule;
        return this;
    }

    public WifiAdapterBuilder SetVersionOfPCIE(string versionOfPCIE)
    {
        ComputerWifiAdapter.VersionOfPCIE = versionOfPCIE;
        return this;
    }

    public WifiAdapterBuilder SetPowerConsumption(double powerConsumption)
    {
        ComputerWifiAdapter.PowerConsumption = powerConsumption;
        return this;
    }

    public IWifiAdapter FinishBuild()
    {
        return ComputerWifiAdapter;
    }
}