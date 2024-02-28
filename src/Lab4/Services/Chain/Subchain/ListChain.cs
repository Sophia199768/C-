namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class ListChain : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "list")
        {
            return new Result.CommandFound(new TreeList());
        }

        return base.Handle(command, index);
    }
}