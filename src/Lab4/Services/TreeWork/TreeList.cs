using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class TreeList : ConsoleCommand
{
    public int Depth { get; set; }
    public IFlag FlagList { get; } = new DephFlag();
    public Dictionary<string, string>? AllFlags { get; private set; }

    public void AddDictionary(Dictionary<string, string> allFlags)
    {
        AllFlags = allFlags;
    }

    public override void Execute(Contecst context)
    {
        if (context is null)
        {
            return;
        }

        if (AllFlags != null) FlagList.Handle(AllFlags, this);
        context.FileSystem.WriteTree(context.Path, Depth);
    }
}