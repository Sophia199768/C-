using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services.FileWork;

public class Copy : ConsoleCommand
{
    public Copy(string sourcePath, string destinationPath)
    {
        SourcePath = sourcePath;
        DestinationPath = destinationPath;
    }

    public string SourcePath { get; private set; }
    public string DestinationPath { get; private set; }

    public override void Execute(Contecst context)
    {
        if (context is null)
        {
            return;
        }

        if (!Path.IsPathRooted(SourcePath))
        {
            SourcePath = Path.Combine(context.Path, SourcePath);
        }

        if (!Path.IsPathRooted(DestinationPath))
        {
            DestinationPath = Path.Combine(context.Path, DestinationPath);
        }

        context.FileSystem.Copy(SourcePath, DestinationPath);
    }
}