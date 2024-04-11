public class Swimming: Activity
{
    private int _numberLaps = 0;



    public Swimming(string date, double lengthMin, int numberLaps): base(date, lengthMin)
    {
        _numberLaps = numberLaps;
        SetActivityId("swimming");
    }


    public override double CalcDistance()
    {
        double distance = _numberLaps * 50 / 1000 * 0.62;
        return distance;
    }


    public override double CalcSpeed()
    {
        double speed = CalcDistance() / GetLengthMin() * 60;
        return speed;
    }


    public override double CalcPace()
    {
        double pace = 60 / CalcSpeed();
        return pace;
    }
}