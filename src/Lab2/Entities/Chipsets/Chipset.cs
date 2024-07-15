using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class Chipset : IChipset
{
    private Collection<int> _memoryFrequencies = new Collection<int>();
    public Chipset(Collection<int> frequencies, Result supportXmp, int chipsetA320Cost)
    {
        _memoryFrequencies = frequencies;
        SupportXMP = supportXmp;
        Cost = chipsetA320Cost;
    }

    public Chipset()
    {
        SupportXMP = new Result.NotGPUCore();
    }

    public Result SupportXMP { get; set; }
    public int Cost { get; set; }

    public void SetFrequencies(Collection<int> frequencies)
    {
        _memoryFrequencies = frequencies;
    }

    public ChipsetBuilder Clone()
    {
        return new ChipsetBuilder(new Chipset(_memoryFrequencies, SupportXMP, Cost));
    }
}