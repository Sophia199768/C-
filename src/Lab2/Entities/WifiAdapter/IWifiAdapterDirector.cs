namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public interface IWifiAdapterDirector
{
    public WifiAdapterBuilder Create(WifiAdapterBuilder builder);
}