using System.Xml.Serialization;

public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, string points) : base(type, name, description, points)
    {

    }


    public override string GetStringRepresentation(bool saveToFile)
    {
        string representation = "";
        if (!saveToFile)
        {
            representation = $"[ ] {_shortName} ({_description})";  
        }


        else
        {
             representation = $"{_type}:{_shortName}~~{_description}~~{_points}";
        }
         
        
        return representation;
    }

    public override bool IsComplete()
    {
        
        return false;
    }

    public override void RecordEvent()
    {
        //_pointsAdder += int.Parse(_points);
    }


    
    public override int GetPointsAdder()
    {
        _pointsAdder = _points;
        return _pointsAdder;
    }

}