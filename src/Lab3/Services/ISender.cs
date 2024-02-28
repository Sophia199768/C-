using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface ISender
{
    public void Send(IMessage sendMessage);
}