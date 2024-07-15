using System.Collections.Generic;
using System.Globalization;
using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

public class DephFlag : BaseFlagHandler
{
    public override Result Handle(IDictionary<string, string> flags, IConsoleCommand consoleCommand)
    {
        if (consoleCommand is TreeList obj)
        {
            if (flags["-d"] is null)
            {
                obj.Depth = 1;
            }
            else
            {
                obj.Depth = int.Parse(flags["-d"], new NumberFormatInfo());
            }
        }

        return base.Handle(flags, consoleCommand);
    }
}