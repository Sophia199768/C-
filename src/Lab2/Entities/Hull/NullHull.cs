namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class NullHull : IHull
{
    private const int NullCost = 0;
    public NullHull()
    {
        MaxLengthGPU = 0;
        MaxWidthGPU = 0;
        FormFactorMotherboard = "null";
        Size = "null";
        Cost = NullCost;
    }

    public int MaxLengthGPU { get; }
    public int MaxWidthGPU { get; }
    public int Cost { get; }
    public string FormFactorMotherboard { get; }
    public string Size { get; }

    public HullBuilder Clone()
    {
        return new HullBuilder(new Hull(MaxLengthGPU, MaxWidthGPU, FormFactorMotherboard, Size, Cost));
    }
}