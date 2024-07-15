namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class Visitor : IVisitor
{
    public string VisitFolder(Folder folder, string output, OutputParams outputParams, int depth)
    {
        output += $"{(outputParams.OffsetSign, depth)} {outputParams.FolderSign} {folder.Name}\n";
        foreach (ITreeComponent component in folder.Files)
        {
            component.Accept(this, output, outputParams, depth);
        }

        return output;
    }

    public string VisitFile(TreeFile file, string output, OutputParams outputParams, int depth)
    {
        output += $"{(outputParams.OffsetSign, depth)} {outputParams.FileSign} {file.Name}\n";
        return output;
    }
}