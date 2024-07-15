using Itmo.ObjectOrientedProgramming.Lab2.Entities.Computers;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public static class InternetShop
{
    public static Result Order(Computer assembling)
    {
        int cost = 0;

        if (ValidatorDisclaimerOfWarranties.DisclaimerOfWarranties(assembling) is Result.DisclaimerOfWarranty
            disclaimerOfWarranty)
        {
            return disclaimerOfWarranty;
        }

        return new Result.SuccessFullOrderCost(assembling, cost);
    }
}