using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class OmegaJumpEngine : IJumpEngine
{
    private const string FailureMessage = "Ship was lost";
    private const int Speed = 120;
    public OmegaJumpEngine()
    {
        Distance = 1000;
        OmegaJumpSpeed = Speed;
    }

    public int Distance { get; }
    public int OmegaJumpSpeed { get; }

    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        if (environment.EnvironmentSize > Distance)
        {
            return new EngineResult.FailEngine(FailureMessage);
        }

        int gasolineAmount = (int)(Math.Log(environment.EnvironmentSize) * environment.ConsumptionRatio);
        return new EngineResult.SuccessUsedJumpEngine(gasolineAmount, environment.EnvironmentSize / OmegaJumpSpeed);
    }
}