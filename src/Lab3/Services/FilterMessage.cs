using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class FilterMessage : ISender
{
    public FilterMessage(ISender concrete, int importanceLevel)
    {
        ConcreteSender = concrete;
        ImportanceLevel = importanceLevel;
    }

    public ISender ConcreteSender { get; }

    public int ImportanceLevel { get; }

    public void Send(IMessage sendMessage)
    {
        Filter(sendMessage);
    }

    public void Filter(IMessage sendMessage)
    {
        if (sendMessage.TakeImportanceLevel >= ImportanceLevel)
        {
            ConcreteSender.Send(sendMessage);
        }
    }
}