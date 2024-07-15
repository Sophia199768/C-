using System.Drawing;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriven;

public interface IDisplayDriver
{
    public string ChoseColor(Color color, string message);
    public void Output(string message, Color color);
}