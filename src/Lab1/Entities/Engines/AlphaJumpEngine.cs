using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class AlphaJumpEngine : IJumpEngine
{
    private const int AlphaDistance = 100;
    private const int Speed = 20;
    private const string FailureMessage = "Ship was lost";
    public AlphaJumpEngine()
    {
        Distance = AlphaDistance;
        AlphaJumpSpeed = Speed;
    }

    public int Distance { get; }
    public int AlphaJumpSpeed { get; }

    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        if (environment.EnvironmentSize > Distance)
        {
            return new EngineResult.FailEngine(FailureMessage);
        }

        int gasolineAmount = environment.EnvironmentSize * environment.ConsumptionRatio;
        return new EngineResult.SuccessUsedJumpEngine(gasolineAmount, environment.EnvironmentSize / AlphaJumpSpeed);
    }
}