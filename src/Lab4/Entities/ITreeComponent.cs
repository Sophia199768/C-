namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public interface ITreeComponent
{
    public string Accept(IVisitor visitor, string output, OutputParams outputParams, int depth);
}