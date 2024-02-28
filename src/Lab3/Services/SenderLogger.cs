using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class SenderLogger : ISender
{
    public SenderLogger(ISender display, ILogger concreteLogger)
    {
        DisplaySender = display;
        ConcreteLogger = concreteLogger;
    }

    public ILogger ConcreteLogger { get; }
    public ISender DisplaySender { get; }

    public int ImportanceLevel { get; }

    public void Send(IMessage sendMessage)
    {
        Logger(sendMessage);
        DisplaySender.Send(sendMessage);
    }

    public void Logger(IMessage sendMessage)
    {
        ConcreteLogger.AddLog(sendMessage);
    }
}