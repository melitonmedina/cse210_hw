using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _type;
    protected int _points;
    protected int _pointsAdder;

    public Goal(string type, string name, string description, string points)
    {
        _type = type;
        _shortName = name;
        _description = description;
        _points = Convert.ToInt16(points);

    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public abstract string GetStringRepresentation(bool saveToFile);


    public abstract int GetPointsAdder();


    public string GetName()
    {
        return _shortName;
    }



}