using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;

public interface IComputerDirectors
{
    public ComputerBuilder Create(ComputerBuilder build);
}