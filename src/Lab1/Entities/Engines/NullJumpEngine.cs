using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Engines;

public class NullJumpEngine : IJumpEngine
{
    private const string FailureMessage = "Ship doesn't have jump engine";
    public EngineResult GasolineConsumption(IEnvironment environment)
    {
        return new EngineResult.FailEngine(FailureMessage);
    }
}