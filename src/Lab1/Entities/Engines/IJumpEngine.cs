using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;
public interface IJumpEngine
{
    public EngineResult GasolineConsumption(IEnvironment environment);
}