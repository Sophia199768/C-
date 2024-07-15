namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

public interface IObstacle
{
    public int Destructiveness { get; }
    public int ObstacleAmount { get; }
}