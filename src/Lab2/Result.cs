using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public abstract record Result
{
    private Result() { }

    public sealed record SuccessfulBuild() : Result;

    public sealed record FailBuilder(string DefaultMessage) : Result;
    public sealed record DisclaimerOfWarranty(string DefaultMessage) : Result;

    public sealed record SuccessFullOrderCost(Computer AssemblyComputerBuilder, int Cost) : Result;

    public sealed record HasGPUCore() : Result;
    public sealed record NotGPUCore() : Result;
    public sealed record HasBluetooth() : Result;
    public sealed record HasNotBluetooth() : Result;

    public sealed record SupportXMP() : Result;

    public sealed record UnSupportXMP() : Result;

    public sealed record ConnectionOptionPCIE() : Result;

    public sealed record ConnectionOptionSATA() : Result;
}