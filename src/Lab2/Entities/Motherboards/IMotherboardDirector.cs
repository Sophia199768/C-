using ConsoleApp3.Entities.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Motherboards;

public interface IMotherboardDirector
{
    public MotherBoardBuilder Create(MotherBoardBuilder motherBoardBuilder);
}