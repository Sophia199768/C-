using Itmo.ObjectOrientedProgramming.Lab1.Entities.Obstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities.Deflectors;

public class Shield : BaseDeflector
{
    private const int NoPhotonic = 0;
    private const string FailureMessage = "Photonic Deflector has dischard";
    public Shield(int photonicDeflectorHp, IDeflector deflector)
    {
        Deflector = deflector;
        PhotonicDeflectorHp = photonicDeflectorHp;
    }

    public IDeflector Deflector { get; }

    public int PhotonicDeflectorHp { get; private set; }

    public HullInfoResult ResidualPhotonicProtection(IObstacle obstacle)
    {
        PhotonicDeflectorHp -= obstacle.ObstacleAmount;
        if (PhotonicDeflectorHp < NoPhotonic)
        {
            return new HullInfoResult.HullWasBroken(FailureMessage);
        }

        return new HullInfoResult.DeflectorIsNotCrushed(PhotonicDeflectorHp);
    }

    public new HullInfoResult ResidualProtection(IObstacle obstacle)
    {
        return Deflector.ResidualProtection(obstacle);
    }
}