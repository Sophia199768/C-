using Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class CopyChain : BaseHandler
{
   public override Result Handle(string[] command, int index)
    {
        if (command[index] == "copy")
        {
            return new Result.CommandFound(new Copy(command[index + 1], command[index + 2]));
        }

        return base.Handle(command, index);
    }
}