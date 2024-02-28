namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public class MarkAsReadDecorator
{
    public MarkAsReadDecorator(IMessage message)
    {
        Message = message;
        ReadenMessage = new Result.MessageWasNotRead();
    }

    public IMessage Message { get; }
    public Result ReadenMessage { get; set; }

    public void ModifyBody(string newMessage)
    {
        Message.TakeBody = newMessage;
    }

    public Result MarkAsRead()
    {
        if (ReadenMessage is Result.MessageWasNotRead)
        {
            ReadenMessage = new Result.MessageWasRead();
            return new Result.MessageWasMarked();
        }

        return new Result.MessegeMistakeMark();
    }
}