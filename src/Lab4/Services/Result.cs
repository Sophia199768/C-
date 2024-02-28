using Itmo.ObjectOrientedProgramming.Lab4.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Services;

public abstract record Result
{
    private Result()
    {
    }

    public sealed record NoSuchCommand(string Message) : Result;

    public sealed record ThisNameAlreadyExist() : Result;

    public sealed record NoMatching(string Message) : Result;

    public sealed record CommandFound(IConsoleCommand Command) : Result;

    public sealed record OperationSuccess() : Result;
    public sealed record FlagFound(string Flag) : Result;

    public sealed record NoNextFlag() : Result;
}