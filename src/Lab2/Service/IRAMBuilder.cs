using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IRAMBuilder
{
    public IDriveBuilder SetRAM(IRAMMemory ram);
}