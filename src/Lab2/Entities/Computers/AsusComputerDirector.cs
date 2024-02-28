using ConsoleApp3.Entities.Motherboards;
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

public class AsusComputerDirector : IComputerDirectors
{
    private ICpu cpu = new IntelCorei7Director().Create(new CpuBuilder()).FinishBuild();
    private IMotherboard motherboard = new AsusMotherBoardDirector().Create(new MotherBoardBuilder()).FinishBuild();
    private IRAMMemory ram = new KingstoneIramDirectors().Create(new RamBuilder()).FinishBuild();
    private ICoolingSystem coolingSystem = new WaterCoolingSystemDirector().Create(new CoolingSystemBuilder()).FinishBuild();
    private IVideoCard videoCard = new NullVideoCard();
    private IDrive drive = new SsdFactory().Create();
    private IHull hull = new BigHullDirector().Create(new HullBuilder()).FinishBuild();
    private IPowerUnit powerUnit = new BigPowerUnitDirector().Create(new PowerUnitBuilder()).FinishBuild();

    public ComputerBuilder Create(ComputerBuilder build)
    {
        build.SetMotherBoard(motherboard)
            .SetCPU(cpu)
            .SetCoolingSystem(coolingSystem)
            .SetRAM(ram)
            .SetDrive(drive)
            .SetHull(hull)
            .SetPowerUnit(powerUnit)
            .SetVideoCard(videoCard);
        return build;
    }
}