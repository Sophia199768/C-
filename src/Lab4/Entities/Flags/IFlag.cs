using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

public interface IFlag
{
    public void SetNext(IFlag nextFlag);
    public Result Handle(IDictionary<string, string> flags, IConsoleCommand consoleCommand);
}