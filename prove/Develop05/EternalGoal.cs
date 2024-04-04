using System.Xml.Serialization;

public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, string points) : base(type, name, description, points)
    {

    }

    public override string GetStringRepresentation()
    {
        
        return "";
    }

    public override bool IsComplete()
    {
        
        return true;
    }

    public override void RecordEvent()
    {

    }
}