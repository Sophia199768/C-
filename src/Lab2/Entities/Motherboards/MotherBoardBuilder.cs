using Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace ConsoleApp3.Entities.Motherboards;

public class MotherBoardBuilder
{
    public MotherBoardBuilder(MotherBoard motherBoard) => ComputerMotherBoard = motherBoard;
    public MotherBoardBuilder() => ComputerMotherBoard = new MotherBoard();
    public MotherBoard ComputerMotherBoard { get; }
    public MotherBoardBuilder SetName(string name)
    {
        ComputerMotherBoard.Name = name;
        return this;
    }

    public MotherBoardBuilder SetSocket(string socket)
    {
        ComputerMotherBoard.Socket = socket;
        return this;
    }

    public MotherBoardBuilder SetCost(int cost)
    {
        ComputerMotherBoard.Cost = cost;
        return this;
    }

    public MotherBoardBuilder SetFormFactor(string formFactor)
    {
        ComputerMotherBoard.FormFactor = formFactor;
        return this;
    }

    public MotherBoardBuilder SetChipset(IChipset chipset)
    {
        ComputerMotherBoard.Chipset = chipset;
        return this;
    }

    public MotherBoardBuilder SetBIOS(IBios bios)
    {
        ComputerMotherBoard.Bios = bios;
        return this;
    }

    public MotherBoardBuilder SetPcie(int amountOfPcie)
    {
        ComputerMotherBoard.AmountOfPCIE = amountOfPcie;
        return this;
    }

    public MotherBoardBuilder SetSata(int amountOfSata)
    {
        ComputerMotherBoard.AmountOfSATA = amountOfSata;
        return this;
    }

    public MotherBoardBuilder SetDdr(int standartDdr)
    {
        ComputerMotherBoard.StandartDDR = standartDdr;
        return this;
    }

    public MotherBoardBuilder SetNumberOfPorts(int amountPorts)
    {
        ComputerMotherBoard.NumberOfPortsForRAM = amountPorts;
        return this;
    }

    public IMotherboard FinishBuild()
    {
        return ComputerMotherBoard;
    }
}