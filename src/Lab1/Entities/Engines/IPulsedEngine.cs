using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public interface IPulsedEngine
{
   public EngineResult GasolineConsumption(IEnvironment environment);
}