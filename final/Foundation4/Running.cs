public class Running: Activity
{
    private double _distance = 0;


    public Running(string date, double lengthMin, double distance): base(date, lengthMin)
    {
        _distance = distance;
        SetActivityId("running");
    }


    public override double CalcDistance()
    {
        return _distance;
    }


    public override double CalcSpeed()
    {
        double speed = _distance/GetLengthMin() * 60.0;
        return speed;
    }


    public override double CalcPace()
    {
        double pace = 60/CalcSpeed();
        return pace;
    }
}