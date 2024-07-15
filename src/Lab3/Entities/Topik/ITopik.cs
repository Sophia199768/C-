using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topik;

public interface ITopik
{
    public void Send(IMessage message);
}