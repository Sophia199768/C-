namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public interface IBiosDirector
{
    public BiosBuilder Create(BiosBuilder build);
}