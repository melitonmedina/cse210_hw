public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string type, string name, string description, string points) : base(type, name, description, points)
    {


    }


//this constructor is used for when loading a file. Because the _isComplete variable needs to be loaded as well, so a different constructor is requiered to set this variable.
   public SimpleGoal(string type, string name, string description, string points, string isComplete) : base(type, name, description, points)
    {
        _isComplete = Convert.ToBoolean(isComplete);
    }


    public override string GetStringRepresentation(bool saveToFile)
    {
        string representation = "";
        if (!saveToFile)
        {
    
            if (_isComplete)
            {
                representation = $"[x] {_shortName} ({_description})";       
            }
            else
            {
                representation = $"[ ] {_shortName} ({_description})"; 
            }
        }
        else
        {
            representation = $"{_type}:{_shortName}~~{_description}~~{_points}~~{_isComplete}";
        }
        return representation;
    }


    
    public override void RecordEvent()
    {
        //_pointsAdder += int.Parse(_points);
        _isComplete = true;       
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }



    public override int GetPointsAdder()
    {
        _pointsAdder = _points;
        return _pointsAdder;
    }
}


