using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public class MessageBuilder : IMessageBuilder
{
    public MessageBuilder(string name, string body)
    {
        Name = name;
        Body = body;
    }

    public string Name { get; set; }
    public string Body { get; set; }
    public int ImportanceLevel { get; set; }

    public IBodyBuilder MessageName(string name)
    {
        Name = name;
        return this;
    }

    public IImportanceLevelBuilder MessageBody(string body)
    {
        Body = body;
        return this;
    }

    public IMessageBuilder MessageImportanceLevel(int level)
    {
        ImportanceLevel = level;
        return this;
    }

    public IMessage Build()
    {
        return new Message(
            Name,
            Body,
            ImportanceLevel);
    }
}