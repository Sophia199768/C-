namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class OutputParams : IOutputParams
{
    public OutputParams()
    {
        FileSign = "📄";
        FolderSign = "🗂";
        OffsetSign = ' ';
    }

    public string FileSign { get; }
    public string FolderSign { get; }
    public char OffsetSign { get; }
}