using ConsoleApp3.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public class NullMotherBoard : IMotherboard
{
    public NullMotherBoard()
    {
        Name = "null";
        Socket = "null";
        AmountOfPCIE = 0;
        AmountOfSATA = 0;
        StandartDDR = 0;
        NumberOfPortsForRAM = 0;
        FormFactor = "null";
        Cost = 0;
        Chipset = new NullChipset();
        Bios = new NullBios();
    }

    public string Name { get; }
    public string Socket { get; }
    public int AmountOfPCIE { get; }
    public int AmountOfSATA { get; }
    public int StandartDDR { get; }
    public int NumberOfPortsForRAM { get; }
    public int Cost { get; }
    public string FormFactor { get; }
    public IChipset Chipset { get; }
    public IBios Bios { get; }

    public MotherBoardBuilder Clone()
    {
        return new MotherBoardBuilder(new MotherBoard(Name, Socket, AmountOfPCIE, AmountOfSATA, StandartDDR, NumberOfPortsForRAM, Cost, FormFactor, Chipset, Bios));
    }
}