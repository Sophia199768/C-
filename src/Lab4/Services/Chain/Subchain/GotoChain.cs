namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class GotoChain : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "goto")
        {
            return new Result.CommandFound(new TreeGoto(command[index + 1]));
        }

        return base.Handle(command, index);
    }
}