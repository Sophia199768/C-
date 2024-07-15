using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class ConcreteLogger : ILogger
{
    private IReadOnlyCollection<IMessage> _savedMessages = new List<IMessage>();

    public ConcreteLogger()
    {
    }

    public void AddLog(IMessage message)
    {
        var save = _savedMessages.ToList();
        save.Add(message);
        _savedMessages = save;
    }

    public IEnumerable<IMessage> ShowLog()
    {
        return _savedMessages;
    }
}