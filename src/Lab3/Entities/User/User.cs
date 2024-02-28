using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.User;

public class User
{
    private IReadOnlyCollection<MarkAsReadDecorator> _savedMessages = new List<MarkAsReadDecorator>();

    public User(string name, int importanceLevel)
    {
        Name = name;
        ImportanceLevel = importanceLevel;
    }

    public User()
    {
        Name = "NoName";
    }

    public string Name { get; set; }

    public int ImportanceLevel { get; }

    public void Recive(IMessage newMessage)
    {
        var messages = _savedMessages.ToList();
        messages.Add(new MarkAsReadDecorator(newMessage));
        _savedMessages = messages;
    }

    public Result MarkedAsRead(string name)
    {
        Result mark = new Result.MessageWasMarked();
        foreach (MarkAsReadDecorator markAsReadDecorator in _savedMessages.Where(obj => obj.Message.TakeMessageName == name))
        {
            mark = markAsReadDecorator.MarkAsRead();
        }

        return mark;
    }

    public IEnumerable<MarkAsReadDecorator> SavedMessages()
    {
        return _savedMessages;
    }
}