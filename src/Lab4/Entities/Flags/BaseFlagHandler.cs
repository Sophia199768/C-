using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

public class BaseFlagHandler : IFlag
{
    public IFlag? NextFlag { get; set; }

    public void SetNext(IFlag nextFlag)
    {
        NextFlag = nextFlag;
    }

    public virtual Result Handle(IDictionary<string, string> flags, IConsoleCommand consoleCommand)
    {
        if (NextFlag is null)
        {
            return new Result.NoNextFlag();
        }

        return NextFlag.Handle(flags, consoleCommand);
    }
}