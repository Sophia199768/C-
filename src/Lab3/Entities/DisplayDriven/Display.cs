using System.Drawing;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriven;

public class Display : IDisplay
{
    public Display(IDisplayDriver driver, Color color)
    {
        Driver = driver;
        Color = color;
    }

    public IDisplayDriver Driver { get; }
    public Color Color { get; }

    public static void Clear()
    {
        string name = "MessageDisplay";
        File.WriteAllText(name, string.Empty);
    }

    public void Recive(string message)
    {
       Clear();
       Driver.Output(message, Color);
   }
}