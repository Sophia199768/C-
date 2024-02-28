using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topik;

public interface ITopikBuilder : ITopikSenderBuilder, ITopikMessageBuilder
{
    public ITopikSenderBuilder TopikName(string name);
    public ITopik Build();
}