using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class Folder : ITreeComponent
{
    public Folder(Collection<ITreeComponent> files, string name)
    {
        Files = files;
        Name = name;
    }

    public Folder(string name)
    {
        Files = new Collection<ITreeComponent>();
        Name = name;
    }

    public string Name { get; }
    public Collection<ITreeComponent> Files { get; }

    public string Accept(IVisitor visitor, string output, OutputParams outputParams, int depth)
    {
        return visitor.VisitFolder(this, output, outputParams, depth + 1);
    }
}