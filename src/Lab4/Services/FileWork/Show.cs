using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

public class Show : ConsoleCommand
{
    public Show(string filePath, string flag)
    {
        FilePath = filePath;
        Flag = flag;
    }

    public string FilePath { get; private set; }
    public string Flag { get; }

    public override void Execute(Contecst context)
    {
        IOutputSystem? outputSystem = null;

        switch (Flag)
        {
            case "console":
                outputSystem = new OutputSystem();
                break;
        }

        if (context is null || outputSystem is null)
        {
            return;
        }

        if (!Path.IsPathRooted(FilePath))
        {
            FilePath = Path.Combine(context.Path, FilePath);
        }

        string file = context.FileSystem.ReadFile(FilePath);
        outputSystem.Show(file);
    }
}