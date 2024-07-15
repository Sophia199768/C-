namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class TreeFile : ITreeComponent
{
    public TreeFile(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public string Accept(IVisitor visitor, string output, OutputParams outputParams, int depth)
    {
        return visitor.VisitFile(this, output, outputParams, depth);
    }
}