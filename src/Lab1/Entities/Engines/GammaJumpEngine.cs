using System;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class GammaJumpEngine : IJumpEngine
{
    private const string FailureMessage = "Ship was lost";
    private const int Speed = 100;
    private const int GammaDistance = 10000;
    private const int Coefficent = 2;
    public GammaJumpEngine()
    {
        Distance = GammaDistance;
        GammaJumpSpeed = Speed;
    }

    public int Distance { get; }
    public int GammaJumpSpeed { get; }
    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        if (environment.EnvironmentSize > Distance)
        {
            return new EngineResult.FailEngine(FailureMessage);
        }

        int gasolineAmount = (int)(Math.Pow(environment.EnvironmentSize, Coefficent) * environment.ConsumptionRatio);
        return new EngineResult.SuccessUsedJumpEngine(gasolineAmount, environment.EnvironmentSize / GammaJumpSpeed);
    }
}