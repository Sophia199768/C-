namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class SmallHullDirector : IHullDirector
{
    private int _maxLengthGPU = 390;
    private int _maxWidthGPU = 200;
    private string _formFactorMotherboard = "mATX";
    private string _size = "Mini-Tower";
    private int _smallHullCost = 8690;

    public HullBuilder Create(HullBuilder build)
    {
        build.SetCost(_smallHullCost);
        build.SetSize(_size);
        build.SetFormFactorMotherboard(_formFactorMotherboard);
        build.SetMaxLengthGPU(_maxLengthGPU);
        build.SetMaxWidthGPU(_maxWidthGPU);
        return build;
    }
}