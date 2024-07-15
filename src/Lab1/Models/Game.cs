using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.Environment;
using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models;

public class Game
{
    private const int MaxFuelAmount = 1000000000;
    private const int Notime = 0;
    private const string DefaultMessage = "Have not managed count fuel";
    private readonly IReadOnlyCollection<IEnvironment> _route;
    public Game(IReadOnlyCollection<IEnvironment> route)
    {
        _route = route;
    }

    public static Result Pass(ISpaceship spaceShip, IEnvironment environment)
    {
       EnvironmentResult pass = environment.ShipStatus(spaceShip);

       if (pass is EnvironmentResult.ShipEnvironmentInfo passEnvironment)
       {
           IFuelExchange fuelExchange = new FuelExchange();
           int amountOfFuel = fuelExchange.GasolineCost(passEnvironment.Engine);
           return new Result.PassageInfo(amountOfFuel, GetTime(passEnvironment.Engine), GetHp(passEnvironment.HullInfo));
       }

       return new Result.ShipWasBroken(DefaultMessage);
    }

    public ISpaceship BestShip(IReadOnlyCollection<ISpaceship> spaceships)
    {
        int fuelCost = MaxFuelAmount;
        ISpaceship bestShip = PleasureShuttle.BuildWithNoPhotonic();
        bool noOnePass = true;

        foreach (IEnvironment section in _route)
        {
            for (int i = 0; i < spaceships.Count; i++)
            {
                Result currentShip = Pass(spaceships.ElementAt(i), section);
                if (currentShip is Result.PassageInfo ship)
                {
                    noOnePass = false;
                    if (fuelCost > ship.AmountOfFuel)
                    {
                        fuelCost = ship.AmountOfFuel;
                        bestShip = spaceships.ElementAt(i);
                    }
                }
            }
        }

        if (noOnePass)
        {
            throw new ArgumentException("No ship exists");
        }

        return bestShip;
    }

    private static int GetHp(HullInfoResult hullInfoResult)
    {
        if (hullInfoResult is HullInfoResult.ShipIsNotCrushed jumpEngine)
        {
            return jumpEngine.Value;
        }

        if (hullInfoResult is HullInfoResult.HullIsNotCrushed pulsedEngine)
        {
            return pulsedEngine.Value;
        }

        return Notime;
    }

    private static int GetTime(EngineResult engineStatus)
    {
        if (engineStatus is EngineResult.SuccessUsedJumpEngine jumpEngine)
        {
            return jumpEngine.Time;
        }

        if (engineStatus is EngineResult.SuccessUsedPulsedEngine pulsedEngine)
        {
            return pulsedEngine.Time;
        }

        return Notime;
    }
}