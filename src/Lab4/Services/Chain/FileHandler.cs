namespace Itmo.ObjectOrientedProgramming.Lab4.Services.Chain;

public class FileHandler : BaseHandler
{
    public override Result Handle(string[] command, int index)
    {
        if (command[index] != "file" || SubNode is null)
        {
            return base.Handle(command, index);
        }

        return SubNode.Handle(command, index + 1);
    }
}