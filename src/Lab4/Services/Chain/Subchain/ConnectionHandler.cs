namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class ConnectionHandler : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "connect")
        {
            return new Result.CommandFound(new Connect(command[index + 1]));
        }

        return base.Handle(command, index);
    }
}