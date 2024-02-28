using Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;

public class ShowChain : BaseHandler
{
    private const string BaseValue = "console";
    public static string GetString(Result deph)
    {
        if (deph is Result.FlagFound obj)
        {
            return obj.Flag;
        }

        return BaseValue;
    }

    public override Result Handle(string[] command, int index)
    {
        if (command[index] == "show")
        {
            Result flag = base.Handle(command, index);
            return new Result.CommandFound(new Show(command[index + 1], GetString(flag)));
        }

        return base.Handle(command, index);
    }
}