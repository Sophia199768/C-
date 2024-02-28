using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class TreeGoto : ConsoleCommand
{
    public TreeGoto(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath { get; private set; }

    public override void Execute(Contecst context)
    {
        if (context is null)
        {
            return;
        }

        if (!Path.IsPathRooted(FilePath))
        {
            FilePath = Path.Combine(context.Path, FilePath);
        }

        context.Path = FilePath;
    }
}