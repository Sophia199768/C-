using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Chipsets;

public class ChipsetB350Director : IChipsetDirector
{
    private Collection<int> _frequences = new Collection<int>() { 2133, 2400, 2666, 2933, 3200 };
    private Result _support = new Result.SupportXMP();
    private int _chipsetB350Cost = 789;

    public ChipsetBuilder Create(ChipsetBuilder builder)
    {
        builder.SetCost(_chipsetB350Cost);
        builder.SetMemoryFrequencies(_frequences);
        builder.SetSupportXMP(_support);
        return builder;
    }
}