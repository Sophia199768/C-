using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

public class Delete : ConsoleCommand
{
    public Delete(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath { get; private set; }

    public override void Execute(Contecst context)
    {
        if (!Path.IsPathRooted(FilePath))
        {
            if (context != null) FilePath = Path.Combine(context.Path, FilePath);
        }

        File.Delete(FilePath);
    }
}