public class Cycling: Activity
{
    private double _speed = 0;


    public Cycling(string date, double lengthMin, double speed): base(date, lengthMin)
    {
        _speed = speed;
        SetActivityId("cycling");
    }


    public override double CalcDistance()
    {
        double distance = _speed/60.0 * GetLengthMin();
        return distance;
    }


    public override double CalcSpeed()
    {
        return _speed;
    }


    public override double CalcPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}