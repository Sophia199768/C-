using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messanger;

public class MessageOut : IShowMessage
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}