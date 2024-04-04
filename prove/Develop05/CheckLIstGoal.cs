public class CheckListGoal : Goal
{
    public CheckListGoal(string type, string name, string description, string points) : base(type, name, description, points)
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