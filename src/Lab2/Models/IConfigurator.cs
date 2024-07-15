using Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public interface IConfigurator
{
    public Result Assembly();
    public void ChangeMotherBoard(IMotherboard motherboard);
    public void ChangeCoolingSystem(ICoolingSystem coolingSystem);
    public void ChangeCPU(ICpu cpu);
    public void ChangeDrive(IDrive drive);
    public void ChangeHull(IHull hull);
    public void ChangePowerUnit(IPowerUnit powerUnit);
    public void ChangeRAM(IRAMMemory ramMemory);
    public void ChangeVideoCard(IVideoCard videoCard);
}