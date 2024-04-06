public class CheckListGoal : Goal
{
    private int _amountCompleted = 0; 
    private int _target = 0;
    private int _bonus = 0;



    public CheckListGoal(string type, string name, string description, string points, string target, string bonus) : base(type, name, description, points)
    {
        _target = Convert.ToInt32(target);
        _bonus = Convert.ToInt32(bonus);

    }


//this constructor is used for when loading a file. Because there the _amountCompleted variable needs to be loaded as well, so a different constructor is requiered to set this variable.
public CheckListGoal(string type, string name, string description, string points, string target, string bonus, string amountCompleted) : base(type, name, description, points)
    {
        _target = Convert.ToInt32(target);
        _bonus = Convert.ToInt32(bonus);
        _amountCompleted = Convert.ToInt32(amountCompleted);

    }



    public override string GetStringRepresentation(bool saveToFile)
    {
                string representation = "";
        if (!saveToFile)
        {
    
            if (_amountCompleted >= _target)
            {
                representation = $"[x] {_shortName} ({_description} -- Currently completed {_amountCompleted}/{_target})";       
            }
            else
            {
                representation = $"[ ] {_shortName} ({_description} -- Currently completed {_amountCompleted}/{_target})"; 
            }
        }
        else
        {
            representation = $"{_type}:{_shortName}~~{_description}~~{_points}~~{_target}~~{_bonus}~~{_amountCompleted}";
        }
        return representation;
    }

    public override bool IsComplete()
    {
        bool isComplete = false;
        
        if (_amountCompleted >= _target)
        {
            isComplete = true;
        }
        return isComplete;
    }

    public override void RecordEvent()
    {
        _amountCompleted +=1;
        
    }


    public override int GetPointsAdder()
    {
        if (_amountCompleted == _target)
        {
            _pointsAdder = _points + _bonus;
        }

        else
        {
          _pointsAdder = _points;  
        }
        
        return _pointsAdder;
    }
}