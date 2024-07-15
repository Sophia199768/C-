using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class PulsedPulsedEngineE : IPulsedEngine
{
    private const int DistsanceCoefficient = 100000;
    public PulsedPulsedEngineE()
    {
        Speed = 15;
    }

    public int Speed { get; }

    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        int gasolineAmount = DistsanceCoefficient * ((int)Math.Pow(Math.E, environment.EnvironmentSize / DistsanceCoefficient)
                              / environment.ConsumptionRatio);
        return new EngineResult.SuccessUsedPulsedEngine(gasolineAmount, environment.EnvironmentSize / Speed);
    }
}