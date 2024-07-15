using System.Drawing;
using System.IO;
using System.Text;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.DisplayDriven;

public class DisplayDriver : IDisplayDriver
{
    public string ChoseColor(Color color, string message)
    {
        return Crayon.Output.Rgb(color.R, color.G, color.B).Text(message);
    }

    public void Output(string message, Color color)
    {
        string colorMessage = ChoseColor(color, message);
        using var fstream = new StreamWriter("MessageDisplay", true, Encoding.ASCII);
        fstream.WriteLine(colorMessage);
    }
}
