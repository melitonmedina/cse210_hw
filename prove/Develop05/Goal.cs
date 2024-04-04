using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _type;
    protected string _points;
    protected int _pointsAdder;

    public Goal(string type, string name, string description, string points)
    {
        _type = type;
        _shortName = name;
        _description = description;
        _points = points;

    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public abstract string GetStringRepresentation();


    public int GetPointsAdder()
    {
        return _pointsAdder;
    }


    public string GetName()
    {
        return _shortName;
    }



}