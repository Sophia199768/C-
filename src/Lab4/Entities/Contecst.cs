namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class Contecst
{
    public Contecst(IFileSystem fileSystem)
    {
        Path = string.Empty;
        FileSystem = fileSystem;
    }

    public string Path { get; set; }
    public IFileSystem FileSystem { get; set; }
}