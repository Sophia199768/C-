namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class ConsoleCommand : IConsoleCommand
{
    public virtual void Execute(Contecst context)
    {
        if (context is null)
        {
            return;
        }
    }
}