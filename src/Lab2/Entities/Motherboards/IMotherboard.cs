using ConsoleApp3.Entities.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IMotherboard
{
    public string Name { get; }
    public string Socket { get; }
    public int Cost { get; }
    public string FormFactor { get; }
    public IChipset Chipset { get; }
    public IBios Bios { get; }
    public MotherBoardBuilder Clone();
}