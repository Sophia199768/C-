using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public interface IMessageBuilder : IBodyBuilder, IImportanceLevelBuilder
{
    public IBodyBuilder MessageName(string name);
    public IMessage Build();
}