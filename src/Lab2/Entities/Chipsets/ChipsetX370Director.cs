using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class ChipsetX370Director : IChipsetDirector
{
    private Collection<int> _frequences = new Collection<int>() { 2133, 2400, 2666, 2933, 3200 };
    private Result _support = new Result.SupportXMP();
    private int _chipsetX370Cost = 673;

    public ChipsetBuilder Create(ChipsetBuilder builder)
    {
        builder.SetCost(_chipsetX370Cost);
        builder.SetMemoryFrequencies(_frequences);
        builder.SetSupportXMP(_support);
        return builder;
    }
}