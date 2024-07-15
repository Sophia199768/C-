using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Entities;

public class OutputSystem : IOutputSystem
{
    private const int StartDepth = 0;
    public OutputParams Pictures { get; } = new OutputParams();
    public void Show(string file)
    {
        Console.Write(file);
    }

    public void ShowTree(Folder treeCut)
    {
        var visitor = new Visitor();
        string tree = string.Empty;
        tree = treeCut.Accept(visitor, tree, Pictures, StartDepth);
        Console.Write(tree);
    }
}