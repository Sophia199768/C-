using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class PulsedPulsedEngineC : IPulsedEngine
{
    public PulsedPulsedEngineC()
    {
        Speed = 10;
    }

    public int Speed { get; }

    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        int gasolineAmount = environment.EnvironmentSize * Speed * Speed * environment.ConsumptionRatio;
        return new EngineResult.SuccessUsedPulsedEngine(gasolineAmount, environment.EnvironmentSize / Speed);
    }
}