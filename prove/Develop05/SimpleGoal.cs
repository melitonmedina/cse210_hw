public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string type, string name, string description, string points) : base(type, name, description, points)
    {


    }

    public override void RecordEvent()
    {
        _pointsAdder += int.Parse(_points);
        _isComplete = true;       
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string representation = "";
        if (_isComplete)
        {
            representation = ($"[x] {_shortName} ({_description})");       
        }
        else
        {
            representation = ($"[] {_shortName} ({_description})"); 
        }
        return representation;
    }
}