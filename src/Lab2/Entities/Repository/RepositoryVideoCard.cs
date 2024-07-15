using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class RepositoryVideoCard
{
    public RepositoryVideoCard()
    {
        VideoCardList.Add(new Rtx3060TiDirector().Create(new VideoCardBuilder()).FinishBuild());
    }

    private List<IVideoCard> VideoCardList { get; } = new List<IVideoCard>();

    public void Add(IVideoCard newCpu)
    {
        VideoCardList.Add(newCpu);
    }

    public IEnumerable<IVideoCard> Get()
    {
        return VideoCardList;
    }
}