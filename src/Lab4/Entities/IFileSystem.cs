using Itmo.ObjectOrientedProgramming.Lab4.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public interface IFileSystem
{
    public string ReadFile(string path);
    public Folder WriteTree(string path, int depth);
    public Result Copy(string sourcePath, string destinationPath);
    public Result Rename(string path, string name);
    public Result Move(string sourcePath, string destinationPath);
}