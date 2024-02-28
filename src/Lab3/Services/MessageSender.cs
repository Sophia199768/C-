using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Messanger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class MessageSender : ISender
{
    public MessageSender(Messanger messanger)
    {
        ConcreteMessanger = messanger;
    }

    public Messanger ConcreteMessanger { get; }

    public void Send(IMessage sendMessage)
    {
        Filter(sendMessage);
    }

    public void Filter(IMessage sendMessage)
    {
        if (sendMessage.TakeImportanceLevel >= ConcreteMessanger.ImportanceLevel)
        {
            string send = $"{sendMessage.TakeMessageName}\n{sendMessage.TakeBody}";
            ConcreteMessanger.ShowMessage(send);
        }
    }
}