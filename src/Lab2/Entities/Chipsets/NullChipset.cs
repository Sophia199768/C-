using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class NullChipset : IChipset
{
    private const int NullChipsetCost = 0;
    public NullChipset()
    {
        SupportXMP = new Result.UnSupportXMP();
        MemoryFrequencies = new Collection<int>();
        Cost = NullChipsetCost;
    }

    public Result SupportXMP { get; }
    public int Cost { get; }
    public Collection<int> MemoryFrequencies { get; }
    public ChipsetBuilder Clone()
    {
        return new ChipsetBuilder(new Chipset(MemoryFrequencies, SupportXMP, Cost));
    }
}