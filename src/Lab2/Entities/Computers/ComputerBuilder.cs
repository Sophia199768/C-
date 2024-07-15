using System;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public class ComputerBuilder : IMotherBuilder, ICPUBuilder, ICoolingSystemBuilder, IRAMBuilder,
        IDriveBuilder, IHullBuilder, IPowerUnitBuilder, ICompliteAssembing, IOptionalAttributesBuilder
{
    public ComputerBuilder(Computer computer)
    {
        CurrentComputer = computer;
    }

    public ComputerBuilder()
    {
        CurrentComputer = new Computer();
    }

    public Computer CurrentComputer { get; }
    public IMotherBuilder StartBuild()
        {
            return this;
        }

    public ICPUBuilder SetMotherBoard(IMotherboard motherboard)
    {
        if (motherboard is NullMotherBoard)
        {
            throw new ArgumentException("You can't create computer without motherboard.");
        }

        CurrentComputer.Motherboard = motherboard;
        return this;
    }

    public ICoolingSystemBuilder SetCPU(ICpu cpu)
    {
        CurrentComputer.Cpu = cpu;
        return this;
    }

    public IRAMBuilder SetCoolingSystem(ICoolingSystem coolingSystem)
    {
        CurrentComputer.CoolingSystem = coolingSystem;
        return this;
    }

    public IDriveBuilder SetRAM(IRAMMemory ram)
    {
        CurrentComputer.RAM = ram;
        return this;
    }

    public IHullBuilder SetDrive(IDrive drive)
    {
        CurrentComputer.Drive = drive;
        return this;
    }

    public IPowerUnitBuilder SetHull(IHull hull)
    {
        if (hull is NullMotherBoard)
        {
            throw new ArgumentException("You can't create computer without hull.");
        }

        CurrentComputer.Hull = hull;
        return this;
    }

    public IOptionalAttributesBuilder SetPowerUnit(IPowerUnit powerUnit)
    {
        if (powerUnit is NullMotherBoard)
        {
            throw new ArgumentException("You can't create computer without power unit.");
        }

        CurrentComputer.PowerUnit = powerUnit;
        return this;
    }

    public IOptionalAttributesBuilder SetVideoCard(IVideoCard videoCard)
    {
        CurrentComputer.VideoCard = videoCard;
        return this;
    }

    public IOptionalAttributesBuilder SetWifiAdapter(IWifiAdapter wifiAdapter)
    {
        CurrentComputer.WifiAdapter = wifiAdapter;
        return this;
    }

    public Computer FinishBuild()
    {
        if (Validator.AssemblyValidation(CurrentComputer) is Result.FailBuilder message)
        {
            throw new ArgumentException(message.DefaultMessage);
        }

        return CurrentComputer;
    }
}