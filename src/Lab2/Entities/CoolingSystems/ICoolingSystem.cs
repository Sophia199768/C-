using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.CoolingSystem;

public interface ICoolingSystem
{
    public int Cost { get; }
    public int TDP { get; }
    public IEnumerable<string> GetSokets();
    public CoolingSystemBuilder Clone();
}