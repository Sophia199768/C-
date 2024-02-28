using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Entities.CPU;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.BIOS;

public interface IBios
{
    public BiosBuilder Clone();
    public IEnumerable<ICpu> GetProcessors();
}