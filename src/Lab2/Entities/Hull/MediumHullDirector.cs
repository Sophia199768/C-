namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Hull;

public class MediumHullDirector : IHullDirector
{
    private int _maxLengthGPU = 370;
    private int _maxWidthGPU = 200;
    private string _formFactorMotherboard = "ATX";
    private string _size = "Midi-Tower";
    private int _mediumHullCost = 12876;

    public HullBuilder Create(HullBuilder build)
    {
        build.SetCost(_mediumHullCost);
        build.SetSize(_size);
        build.SetFormFactorMotherboard(_formFactorMotherboard);
        build.SetMaxLengthGPU(_maxLengthGPU);
        build.SetMaxWidthGPU(_maxWidthGPU);
        return build;
    }
}