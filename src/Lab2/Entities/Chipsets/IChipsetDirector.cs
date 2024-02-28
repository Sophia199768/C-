namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public interface IChipsetDirector
{
    public ChipsetBuilder Create(ChipsetBuilder builder);
}