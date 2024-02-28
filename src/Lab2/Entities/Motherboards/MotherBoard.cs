using ConsoleApp3.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public class MotherBoard : IMotherboard
{
    public MotherBoard(
        string name,
        string socket,
        int amountOfPcie,
        int amountOfSata,
        int standartDdr,
        int numberOfPortsForRam,
        int cost,
        string formFactor,
        IChipset chipset,
        IBios bios)
    {
        Name = name;
        Socket = socket;
        AmountOfPCIE = amountOfPcie;
        AmountOfSATA = amountOfSata;
        StandartDDR = standartDdr;
        NumberOfPortsForRAM = numberOfPortsForRam;
        Cost = cost;
        FormFactor = formFactor;
        Chipset = chipset;
        Bios = bios;
    }

    public MotherBoard()
    {
        Name = string.Empty;
        Socket = string.Empty;
        FormFactor = string.Empty;
        Chipset = new Chipset();
        Bios = new Bios();
    }

    public string Name { get; set; }
    public string Socket { get; set; }
    public int AmountOfPCIE { get; set; }
    public int AmountOfSATA { get; set; }
    public int StandartDDR { get; set; }
    public int NumberOfPortsForRAM { get; set; }
    public int Cost { get; set; }
    public string FormFactor { get; set; }
    public IChipset Chipset { get; set; }
    public IBios Bios { get; set; }

    public MotherBoardBuilder Clone()
    {
        return new MotherBoardBuilder(new MotherBoard(Name, Socket, AmountOfPCIE, AmountOfSATA, StandartDDR, NumberOfPortsForRAM, Cost, FormFactor, Chipset, Bios));
    }
}