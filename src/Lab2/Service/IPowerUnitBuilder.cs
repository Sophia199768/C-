using Itmo.ObjectOrientedProgramming.Lab2.Entities.PowerUnit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IPowerUnitBuilder
{
    public IOptionalAttributesBuilder SetPowerUnit(IPowerUnit powerUnit);
}