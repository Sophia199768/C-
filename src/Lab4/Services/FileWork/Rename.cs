using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

public class Rename : ConsoleCommand
{
    public Rename(string filePath, string name)
    {
        FilePath = filePath;
        Name = name;
    }

    public string FilePath { get; private set; }
    public string Name { get; }

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

        context.FileSystem.Rename(FilePath, Name);
    }
}