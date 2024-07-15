using ConsoleApp3.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public class AsusMotherBoardDirector : IMotherboardDirector
{
    private string _name = "ASUS";
    private string _socket = "LGA1700";
    private int _amountOfPcie = 1;
    private int _amountOfSata = 4;
    private int _standartDDR = 4;
    private int _numberOfPortsForRam = 2;
    private int _cost = 10190;
    private string _formFactor = "mATX";
    private IChipset _chipset = new ChipsetB350Director().Create(new ChipsetBuilder()).FinishBuild();
    private IBios _bios = new UEFIFactory().Create(new BiosBuilder()).FinishBuild();

    public MotherBoardBuilder Create(MotherBoardBuilder motherBoardBuilder)
    {
        motherBoardBuilder.SetName(_name);
        motherBoardBuilder.SetSocket(_socket);
        motherBoardBuilder.SetPcie(_amountOfPcie);
        motherBoardBuilder.SetSata(_amountOfSata);
        motherBoardBuilder.SetDdr(_standartDDR);
        motherBoardBuilder.SetCost(_cost);
        motherBoardBuilder.SetFormFactor(_formFactor);
        motherBoardBuilder.SetNumberOfPorts(_numberOfPortsForRam);
        motherBoardBuilder.SetChipset(_chipset);
        motherBoardBuilder.SetBIOS(_bios);
        return motherBoardBuilder;
    }
}