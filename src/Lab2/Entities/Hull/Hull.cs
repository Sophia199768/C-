namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class Hull : IHull
{
    public Hull(int maxLengthGpu, int maxWidthGpu, string formFactorMotherboard, string size, int cost)
    {
        MaxLengthGPU = maxLengthGpu;
        MaxWidthGPU = maxWidthGpu;
        FormFactorMotherboard = formFactorMotherboard;
        Size = size;
        Cost = cost;
    }

    public Hull()
    {
        FormFactorMotherboard = string.Empty;
        Size = string.Empty;
    }

    public int MaxLengthGPU { get; set; }
    public int MaxWidthGPU { get; set; }
    public int Cost { get; set; }
    public string FormFactorMotherboard { get; set; }
    public string Size { get; set; }

    public HullBuilder Clone()
    {
        return new HullBuilder(new Hull(MaxLengthGPU, MaxWidthGPU, FormFactorMotherboard, Size, Cost));
    }
}