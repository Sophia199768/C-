using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Services.Chain;
using Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain;
using ConnectionHandler = Itmo.ObjectOrientedProgramming.Lab4.Services.Chain.Subchain.ConnectionHandler;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public class Parser
{
    private Dictionary<string, string> allFlags = new Dictionary<string, string>();
    public Parser()
    {
        var fileHandler = new FileHandler();
        var treeHandler = new TreeHandler();
        var connectionChain = new ConnectionHandler();
        var disconnectionChain = new DisconnectionHandler();
        Root = connectionChain;
        Root.SetNext(disconnectionChain);
        disconnectionChain.SetNext(treeHandler);
        treeHandler.SetNext(fileHandler);

        var copyChain = new CopyChain();
        var deleteChain = new DeleteChain();
        var moveChain = new MoveChain();
        var renameChain = new RenameChain();
        var showChain = new ShowChain();
        copyChain.SetNext(deleteChain);
        deleteChain.SetNext(moveChain);
        moveChain.SetNext(renameChain);
        renameChain.SetNext(showChain);
        fileHandler.SetSubNode(copyChain);

        var gotoChain = new GotoChain();
        var listChain = new ListChain();
        gotoChain.SetNext(listChain);
        treeHandler.SetSubNode(gotoChain);
    }

    public BaseHandler Root { get; }
    public Result ReadCommand(string allString)
    {
        string[] command = allString.Split(' ');
        for (int i = 0; i < command.Length; i++)
        {
            if (command[i][0] == '-')
            {
                allFlags[command[i]] = command[i + 1];
            }
        }

        int index = 0;
        Result result = Root.Handle(command, index);

        if (result is Result.CommandFound obj)
        {
            switch (obj.Command)
            {
                case Connect connect:
                    connect.AddDictionary(allFlags);
                    break;
                case TreeList treeList:
                    treeList.AddDictionary(allFlags);
                    break;
            }
        }

        return result;
    }
}