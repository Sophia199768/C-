using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Topik;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;

public interface ITopikMessageBuilder
{
    public ITopikBuilder TopikMessage(IMessage message);
}