using Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriven;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class DisplaySender : ISender
{
    public DisplaySender(IDisplay display)
    {
        ConcreteMessanger = display;
    }

    public IDisplay ConcreteMessanger { get; }

    public void Send(IMessage sendMessage)
    {
        string newMessage = $"{sendMessage.TakeMessageName}\n{sendMessage.TakeBody}";
        ConcreteMessanger.Recive(newMessage);
    }
}