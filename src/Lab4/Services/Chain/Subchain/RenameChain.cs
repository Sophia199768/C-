using Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class RenameChain : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "rename")
        {
            return new Result.CommandFound(new Rename(command[index + 1], command[index + 2]));
        }

        return base.Handle(command, index);
    }
}