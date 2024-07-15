using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class AntimatterFlares : IDenseNebulaeObstacles
{
    private const int NoObstacles = 0;
    public AntimatterFlares(int amount = 0)
    {
        Destructiveness = 0;
        if (amount < NoObstacles)
        {
            throw new ArgumentException("Negative obstacle amount");
        }

        ObstacleAmount = amount;
    }

    public int Destructiveness { get; }
    public int ObstacleAmount { get; }
}