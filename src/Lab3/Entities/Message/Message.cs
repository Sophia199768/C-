namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public class Message : IMessage
{
    public Message(
        string name,
        string body,
        int importanceLevel)
    {
        TakeMessageName = name;
        TakeBody = body;
        TakeImportanceLevel = importanceLevel;
    }

    public int TakeImportanceLevel { get; }
    public string TakeMessageName { get; }
    public string TakeBody { get; set; }
}