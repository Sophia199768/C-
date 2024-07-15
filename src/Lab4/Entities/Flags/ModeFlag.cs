using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

public class ModeFlag : BaseFlagHandler
{
    public override Result Handle(IDictionary<string, string> flags, IConsoleCommand consoleCommand)
    {
        if (consoleCommand is Connect obj)
        {
            if (obj.Contecst is null)
            {
                return new Result.NoMatching("No contecst");
            }

            if (flags["-m"] is null)
            {
                return new Result.NoNextFlag();
            }

            switch (flags["-m"])
            {
                case "local":
                    obj.Contecst.FileSystem = new BaseFileSystem();
                    break;
            }
        }

        return base.Handle(flags, consoleCommand);
    }
}