using Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Entities.User;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class UserSender : ISender
{
    public UserSender(User user)
    {
        ConcreteUser = user;
    }

    public User ConcreteUser { get; }

    public int ImportanceLevel { get; }

    public void Send(IMessage sendMessage)
    {
        ConcreteUser.Recive(sendMessage);
    }
}
