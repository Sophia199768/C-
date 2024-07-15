using System;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class InputCommands
{
    public virtual void Input()
    {
        string? command;

        var contecst = new Contecst(new BaseFileSystem());
        while (true)
        {
            command = Console.ReadLine();

            if (command is null)
            {
                return;
            }

            var parser = new Parser();
            Result consoleCommand = parser.ReadCommand(command);

            if (consoleCommand is Result.CommandFound obj)
            {
                obj.Command.Execute(contecst);
                if (obj.Command is Disconnect) return;
            }
        }
    }
}