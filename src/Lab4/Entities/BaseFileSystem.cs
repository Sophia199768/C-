using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class BaseFileSystem : IFileSystem
{
    private const int FindFreeName = 10;
    private int Depth { get; set; }
    public string ReadFile(string path)
    {
        string fileText = File.ReadAllText(path);
        return fileText;
    }

    public Folder WriteTree(string path, int depth)
    {
        Depth = depth;
        var treeCut = new Folder(string.Empty);
        Print(path, 0, treeCut);
        return treeCut;
    }

    public Result Copy(string sourcePath, string destinationPath)
    {
        var file = new FileInfo(sourcePath);
        string fileName = file.Name;

        if (!File.Exists(Path.Combine(destinationPath, fileName)))
        {
            File.Copy(sourcePath, Path.Combine(destinationPath, fileName));
            return new Result.OperationSuccess();
        }
        else
        {
            for (int i = 0; i < FindFreeName; i++)
            {
                if (!File.Exists(Path.Combine(Path.Combine(destinationPath, fileName), "(" + i + ")")))
                {
                    File.Copy(sourcePath, Path.Combine(Path.Combine(destinationPath, fileName), "(" + i + ")"));
                    return new Result.OperationSuccess();
                }
            }
        }

        return new Result.ThisNameAlreadyExist();
    }

    public Result Rename(string path, string name)
    {
        string? mainPath = Path.GetDirectoryName(path);

        if (mainPath == null)
        {
            return new Result.NoSuchCommand("No main pass");
        }

        if (!File.Exists(Path.Combine(mainPath, name)))
        {
            File.Move(path, Path.Combine(mainPath, name));
            return new Result.OperationSuccess();
        }
        else
        {
            for (int i = 0; i < FindFreeName; i++)
            {
                if (!File.Exists(Path.Combine(Path.Combine(mainPath, name), "(" + i + ")")))
                {
                    File.Move(path,    Path.Combine(Path.Combine(mainPath, name), "(" + i + ")"));
                    return new Result.OperationSuccess();
                }
            }
        }

        return new Result.ThisNameAlreadyExist();
    }

    public Result Move(string sourcePath, string destinationPath)
    {
        var file = new FileInfo(sourcePath);
        string fileName = file.Name;
        File.Move(sourcePath, Path.Combine(destinationPath, fileName));

        if (!File.Exists(Path.Combine(destinationPath, fileName)))
        {
            File.Move(sourcePath, Path.Combine(destinationPath, fileName));
            return new Result.OperationSuccess();
        }
        else
        {
            for (int i = 0; i < FindFreeName; i++)
            {
                if (!File.Exists(Path.Combine(Path.Combine(destinationPath, fileName), "(" + i + ")")))
                {
                    File.Move(sourcePath, Path.Combine(Path.Combine(destinationPath, fileName), "(" + i + ")"));
                    return new Result.OperationSuccess();
                }
            }
        }

        return new Result.ThisNameAlreadyExist();
    }

    private void Print(string path, int depth, Folder tree)
    {
        if (depth == Depth || !Directory.Exists(path)) return;

        foreach (string current in Directory.EnumerateFiles(path))
        {
            string fileName = Path.GetFileName(current);
            tree.Files.Add(new TreeFile(fileName));
        }

        foreach (string current in Directory.EnumerateDirectories(path))
        {
            string folderName = Path.GetDirectoryName(current) ?? string.Empty;
            var subfolder = new Folder(folderName);
            Print(current, depth + 1, subfolder);
            tree.Files.Add(subfolder);
        }
    }
}