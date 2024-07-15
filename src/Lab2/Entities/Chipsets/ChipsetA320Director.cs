using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class ChipsetA320Director : IChipsetDirector
{
    private Collection<int> _frequences = new Collection<int>() { 2667, 2933 };
    private Result _support = new Result.SupportXMP();
    private int _chipsetA320Cost = 400;

    public ChipsetBuilder Create(ChipsetBuilder builder)
    {
        builder.SetCost(_chipsetA320Cost);
        builder.SetMemoryFrequencies(_frequences);
        builder.SetSupportXMP(_support);
        return builder;
    }
}