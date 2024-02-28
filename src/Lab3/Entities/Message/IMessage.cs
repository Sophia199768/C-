namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public interface IMessage
{
    public int TakeImportanceLevel { get; }
    public string TakeBody { get; set; }
    public string TakeMessageName { get; }
}