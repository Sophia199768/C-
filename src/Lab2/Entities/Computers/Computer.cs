using Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;

public class Computer
{
    public Computer(
        ICpu cpu,
        IMotherboard motherboard,
        IRAMMemory ramMemory,
        ICoolingSystem coolingSystem,
        IVideoCard videoCard,
        IDrive drive,
        IHull hull,
        IPowerUnit powerUnit,
        IWifiAdapter wifiAdapter)
    {
        Cpu = cpu;
        Motherboard = motherboard;
        RAM = ramMemory;
        CoolingSystem = coolingSystem;
        VideoCard = videoCard;
        Drive = drive;
        Hull = hull;
        PowerUnit = powerUnit;
        WifiAdapter = wifiAdapter;
    }

    public Computer()
    {
    }

    public ICpu Cpu { get; set; } = new NullCpu();
    public IMotherboard Motherboard { get; set; } = new NullMotherBoard();
    public IRAMMemory RAM { get; set; } = new NullRAM();
    public ICoolingSystem CoolingSystem { get; set; } = new NullCoolingSystem();
    public IVideoCard VideoCard { get; set; } = new NullVideoCard();
    public IDrive Drive { get; set; } = new NullDrive();
    public IHull Hull { get; set; } = new NullHull();
    public IPowerUnit PowerUnit { get; set; } = new NullPowerUnit();
    public IWifiAdapter WifiAdapter { get; set; } = new NullWifiAdapter();

    public ComputerBuilder Clone()
    {
        return new ComputerBuilder(new Computer(
            Cpu,
            Motherboard,
            RAM,
            CoolingSystem,
            VideoCard,
            Drive,
            Hull,
            PowerUnit,
            WifiAdapter));
    }
}