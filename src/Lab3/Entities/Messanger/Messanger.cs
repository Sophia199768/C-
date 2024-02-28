namespace Itmo.ObjectOrientedProgramming.Lab3.Entities.Messanger;

public class Messanger : IMessanger
{
    public Messanger(int importanceLevel)
    {
        ImportanceLevel = importanceLevel;
        Show = new MessageOut();
    }

    public int ImportanceLevel { get; }
    public IShowMessage Show { get; }
    public void ShowMessage(string message)
    {
        Show.ShowMessage(message);
    }
}