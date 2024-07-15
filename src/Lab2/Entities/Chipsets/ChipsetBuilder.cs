using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class ChipsetBuilder
{
    public ChipsetBuilder(Chipset chipset) => MotherBoardChipset = chipset;
    public ChipsetBuilder() => MotherBoardChipset = new Chipset();
    public Chipset MotherBoardChipset { get; }

    public ChipsetBuilder SetSupportXMP(Result supportXMP)
    {
        MotherBoardChipset.SupportXMP = supportXMP;
        return this;
    }

    public ChipsetBuilder SetCost(int cost)
    {
        MotherBoardChipset.Cost = cost;
        return this;
    }

    public ChipsetBuilder SetMemoryFrequencies(Collection<int> memoryFrequencies)
    {
        MotherBoardChipset.SetFrequencies(memoryFrequencies);
        return this;
    }

    public IChipset FinishBuild()
    {
        return MotherBoardChipset;
    }
}