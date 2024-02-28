using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;

public class DenseNebulae : IEnvironment
{
    private const int Ratio = 20;
    private const string DeadTeam = "The ship was dead";
    private const string DefaultMessage = "Spaceship was broken";

    public DenseNebulae(IDenseNebulaeObstacles obstacle, int environmentSize = 1)
    {
        ConsumptionRatio = Ratio;
        RouteObstacle = obstacle;
        EnvironmentSize = environmentSize;
    }

    public DenseNebulae(int environmentSize = 1)
    {
        ConsumptionRatio = Ratio;
        RouteObstacle = null;
        EnvironmentSize = environmentSize;
    }

    public int ConsumptionRatio { get; }
    public IObstacle? RouteObstacle { get; }

    public int EnvironmentSize { get; }

    public EngineResult FuelForSuccessRoute(ISpaceship spaceship)
    {
        if (RouteObstacle is not null)
        {
            if (spaceship.PresenceOfPhotonicDeflector(RouteObstacle) is HullInfoResult.HullWasBroken)
            {
                return new EngineResult.FailEngine(DeadTeam);
            }
        }

        return spaceship.ShipJumpEngine.GasolineConsumption(this);
    }

    public HullInfoResult IntegrityOfHull(ISpaceship spaceship)
    {
        if (RouteObstacle is null)
        {
            if (spaceship.Hull.ResidualProtection(new Fragments()) is HullInfoResult.HullIsNotCrushed hull
                && spaceship.ShipShield.ResidualProtection(new Fragments()) is HullInfoResult.Fragments deflectors)
            {
                return new HullInfoResult.ShipIsNotCrushed(hull.Value + deflectors.Hp);
            }

            return new HullInfoResult.HullWasBroken(DefaultMessage);
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