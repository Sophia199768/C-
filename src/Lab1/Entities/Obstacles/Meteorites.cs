using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Meteorites : ISimpleSpaceObstacle
{
    private const int DestructivnessCoefficient = 23;
    private const int NoObstacles = 0;

    public Meteorites(int amount = 1)
    {
        if (amount < NoObstacles)
        {
            throw new ArgumentException("Negative obstacle amount");
        }

        Destructiveness = DestructivnessCoefficient * amount;
        ObstacleAmount = amount;
    }

    public int Destructiveness { get; }

    public int ObstacleAmount { get; }
}