namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public interface IVisitor
{
    public string VisitFolder(Folder folder, string output, OutputParams outputParams, int depth);
    public string VisitFile(TreeFile file, string output, OutputParams outputParams, int depth);
}