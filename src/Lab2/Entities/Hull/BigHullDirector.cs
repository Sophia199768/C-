namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class BigHullDirector : IHullDirector
{
    private int _maxLengthGPU = 420;
    private int _maxWidthGPU = 300;
    private string _formFactorMotherboard = "mATX";
    private string _size = "Full-Tower";
    private int _bigHullCost = 28690;

    public HullBuilder Create(HullBuilder build)
    {
        build.SetCost(_bigHullCost);
        build.SetSize(_size);
        build.SetFormFactorMotherboard(_formFactorMotherboard);
        build.SetMaxLengthGPU(_maxLengthGPU);
        build.SetMaxWidthGPU(_maxWidthGPU);
        return build;
    }
}