using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class Disconnect : ConsoleCommand
{
    public override void Execute(Contecst context)
    {
        if (context != null) context.Path = string.Empty;
    }
}