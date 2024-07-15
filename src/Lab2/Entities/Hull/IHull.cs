namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public interface IHull
{
    public int MaxLengthGPU { get; }
    public int MaxWidthGPU { get; }
    public int Cost { get; }
    public string FormFactorMotherboard { get; }
    public HullBuilder Clone();
}