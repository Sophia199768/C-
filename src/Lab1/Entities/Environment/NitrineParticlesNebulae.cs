using Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class NitrineParticlesNebulae : IEnvironment
{
    private const int Ratio = 1000;

    public NitrineParticlesNebulae(INitrineParticlesNebulaeObstacles obstacle, int environmentSize = 1)
    {
        ConsumptionRatio = Ratio;
        RouteObstacle = obstacle;
        EnvironmentSize = environmentSize;
    }

    public NitrineParticlesNebulae(int environmentSize = 1)
    {
        ConsumptionRatio = Ratio;
        RouteObstacle = null;
        EnvironmentSize = environmentSize;
    }

    public IObstacle? RouteObstacle { get; }
    public int ConsumptionRatio { get; }
    public int EnvironmentSize { get; }

    public EngineResult FuelForSuccessRoute(ISpaceship spaceship)
    {
        return spaceship.ShipPulsedEngine.GasolineConsumption(this);
    }

    public HullInfoResult IntegrityOfHull(ISpaceship spaceship)
    {
        if (spaceship.Emitter is AntiNitrineЕmitter)
        {
           var hull = spaceship.Hull.ResidualProtection(new Fragments()) as HullInfoResult.HullIsNotCrushed;
           var deflectors = spaceship.ShipShield.ResidualProtection(new Fragments()) as HullInfoResult.Fragments;
           return new HullInfoResult.ShipIsNotCrushed(hull?.Value + deflectors?.Hp ?? 0);
        }

        if (RouteObstacle is null)
        {
            var hull = spaceship.Hull.ResidualProtection(new Fragments()) as HullInfoResult.ShipIsNotCrushed;
            var deflectors = spaceship.ShipShield.ResidualProtection(new Fragments()) as HullInfoResult.Fragments;
            return new HullInfoResult.ShipIsNotCrushed(hull?.Value + deflectors?.Hp ?? 0);
        }

        if (spaceship.ShipShield.ResidualProtection(RouteObstacle) is HullInfoResult.Fragments fragments)
        {
            return spaceship.Hull.ResidualProtection(fragments.Fragment);
        }

        return spaceship.Hull.ResidualProtection(new Fragments());
    }

    public EnvironmentResult ShipStatus(ISpaceship spaceship)
    {
        HullInfoResult hull = IntegrityOfHull(spaceship);
        EngineResult engine = FuelForSuccessRoute(spaceship);
        if (hull is HullInfoResult.HullWasBroken integrityOfHull)
        {
            return new EnvironmentResult.CantPassEnvironment(integrityOfHull.DefaultMessage);
        }

        if (engine is EngineResult.FailEngine fuelForSuccessRoute)
        {
            return new EnvironmentResult.CantPassEnvironment(fuelForSuccessRoute.DefaultMessage);
        }

        return new EnvironmentResult.ShipEnvironmentInfo(engine, hull);
    }
}