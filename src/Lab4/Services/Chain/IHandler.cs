namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain;

public interface IHandler
{
    public void SetNext(IHandler handler);
    public void SetSubNode(IHandler handler);
    public Result Handle(string[] command, int index);
}