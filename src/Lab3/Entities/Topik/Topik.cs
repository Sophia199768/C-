using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Topik;

public class Topik : ITopik
{
    private readonly string _name;
    private readonly ISender _sender;
    public Topik(
        string name,
        ISender sender)
    {
        _name = name;
        _sender = sender;
    }

    public void Send(IMessage message)
    {
        _sender.Send(message);
    }
}