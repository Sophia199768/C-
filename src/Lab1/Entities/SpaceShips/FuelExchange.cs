namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShips;

public class FuelExchange : IFuelExchange
{
    private const int JumpEngineFuelCostPerLiter = 100;
    private const int PulsedEngineCostPerLiter = 10;
    private const int DefaultCost = 0;

    public int GasolineCost(EngineResult fuel)
    {
        if (fuel is EngineResult.SuccessUsedJumpEngine amount)
        {
            return JumpEngineFuelCostPerLiter * amount.AmountOfFuel;
        }

        var amountOfFuel = fuel as EngineResult.SuccessUsedPulsedEngine;
        return PulsedEngineCostPerLiter * amountOfFuel?.AmountOfFuel ?? DefaultCost;
    }
}