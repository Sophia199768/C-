namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class DisconnectionHandler : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "disconnect")
        {
            return new Result.CommandFound(new Disconnect());
        }

        return base.Handle(command, index);
    }
}