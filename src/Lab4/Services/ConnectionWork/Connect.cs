using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.Entities.Flags;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class Connect : ConsoleCommand
{
    public Connect(string path)
    {
       Path = path;
    }

    public string Path { get; set; }
    public IFlag FlagList { get; } = new ModeFlag();
    public Dictionary<string, string>? AllFlags { get; private set; }
    public Contecst? Contecst { get; set; }

    public void AddDictionary(Dictionary<string, string> allFlags)
    {
        AllFlags = allFlags;
    }

    public override void Execute(Contecst context)
    {
        Contecst = context;
        if (AllFlags != null) FlagList.Handle(AllFlags, this);
        if (Contecst != null) Contecst.Path = Path;
    }
}