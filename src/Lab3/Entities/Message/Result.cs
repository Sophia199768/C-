namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Message;

public abstract record Result
{
    public sealed record MessageWasRead() : Result;

    public sealed record MessageWasNotRead() : Result;

    public sealed record MessageWasMarked() : Result;

    public sealed record MessegeMistakeMark() : Result;
}