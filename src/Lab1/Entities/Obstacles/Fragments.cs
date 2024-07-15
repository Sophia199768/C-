namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public class Fragments : IObstacle
{
    public Fragments(int destructiveness = 0)
    {
        Destructiveness = destructiveness;
    }

    public int Destructiveness { get; }
    public int ObstacleAmount { get; }
}