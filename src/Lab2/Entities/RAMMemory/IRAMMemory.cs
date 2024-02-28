namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public interface IRAMMemory
{
    public int FrequensyJedec { get; }
    public int Cost { get; }
    public RamBuilder Clone();
}