using Itmo.ObjectOrientedProgramming.Lab2.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.VideoCard;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IOptionalAttributesBuilder
{
    public IOptionalAttributesBuilder SetWifiAdapter(IWifiAdapter wifiAdapter);
    public IOptionalAttributesBuilder SetVideoCard(IVideoCard videoCard);
    public Computer FinishBuild();
}