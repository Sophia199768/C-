using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class GroupSender : ISender
{
    private IReadOnlyCollection<ISender> _senders = new List<ISender>();

    public GroupSender(IReadOnlyCollection<ISender> senders)
    {
        _senders = senders;
    }

    public int ImportanceLevel { get; }

    public void Send(IMessage sendMessage)
    {
        foreach (ISender sender in _senders)
        {
            sender.Send(sendMessage);
        }
    }
}