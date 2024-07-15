namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

public interface IVideoCardDirector
{
    public VideoCardBuilder Create(VideoCardBuilder builder);
}