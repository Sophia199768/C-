using Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class DeleteChain : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "delete")
        {
            return new Result.CommandFound(new Delete(command[index + 1]));
        }

        return base.Handle(command, index);
    }
}