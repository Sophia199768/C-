using Itmo.ObjectOrientedProgramming.Lab2.Entities.Drive;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public interface IDriveBuilder
{
    public IHullBuilder SetDrive(IDrive drive);
}