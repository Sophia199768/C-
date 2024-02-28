namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class HullBuilder
{
    public HullBuilder(Hull hull) => ComputerHull = hull;
    public HullBuilder() => ComputerHull = new Hull();
    public Hull ComputerHull { get; }
    public HullBuilder SetMaxLengthGPU(int length)
    {
        ComputerHull.MaxLengthGPU = length;
        return this;
    }

    public HullBuilder SetMaxWidthGPU(int width)
    {
        ComputerHull.MaxWidthGPU = width;
        return this;
    }

    public HullBuilder SetCost(int cost)
    {
        ComputerHull.Cost = cost;
        return this;
    }

    public HullBuilder SetFormFactorMotherboard(string formFactor)
    {
        ComputerHull.FormFactorMotherboard = formFactor;
        return this;
    }

    public HullBuilder SetSize(string size)
    {
        ComputerHull.Size = size;
        return this;
    }

    public IHull FinishBuild()
    {
        return ComputerHull;
    }
}