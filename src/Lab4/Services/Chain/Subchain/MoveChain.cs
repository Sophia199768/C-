using Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class MoveChain : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "move")
        {
            return new Result.CommandFound(new Move(command[index + 1], command[index + 2]));
        }

        return base.Handle(command, index);
    }
}