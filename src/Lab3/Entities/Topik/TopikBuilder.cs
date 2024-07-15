using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topik;

public class TopikBuilder : ITopikBuilder
{
    public TopikBuilder(string name, IMessage message, ISender sender)
    {
        Name = name;
        SendMessage = message;
        MessageSender = sender;
    }

    public string Name { get; set; }
    public IMessage SendMessage { get; set; }
    public ISender MessageSender { get; set; }

    public ITopikSenderBuilder TopikName(string name)
    {
        Name = name;
        return this;
    }

    public ITopikMessageBuilder Sender(ISender sender)
    {
        MessageSender = sender;
        return this;
    }

    public ITopikBuilder TopikMessage(IMessage message)
    {
        SendMessage = message;
        return this;
    }

    public ITopik Build()
    {
        return new Topik(
            Name,
            MessageSender);
    }
}