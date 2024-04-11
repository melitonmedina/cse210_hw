public class Activity
{
    private string _date = "";
    private double _lengthMin = 0;
    private string _activityId = "";
    


    public Activity(string date, double lengthMin)
    {
        _date = date;
        _lengthMin = lengthMin;
    }


    public void SetActivityId(string id)
    {
        _activityId = id;
    }


    public virtual double CalcDistance()
    {
        return 0;
    }


    public virtual double CalcSpeed()
    {
        return 0;
    }


    public virtual double CalcPace()
    {
        return 0;
    }


    public string GetSummary()
    {
        string getSummaryString = "";

        if (_activityId.ToLower() == "running")
        {
            getSummaryString = $"{_date} Running ({_lengthMin:0.0#} min)- {CalcDistance():0.0#} miles, Speed {CalcSpeed():0.0#}, Pace: {CalcPace():0.0#} min per mile";
        }


        else if (_activityId.ToLower() == "cycling")
        {
            getSummaryString = $"{_date} Cycling ({_lengthMin:0.0#} min)- {CalcDistance():0.0#} miles, Speed {CalcSpeed():0.0#}, Pace: {CalcPace():0.0#} min per mile";
        }


        else
        {
            getSummaryString = $"{_date} Swimming ({_lengthMin:0.0#} min)- {CalcDistance():0.0#} miles, Speed {CalcSpeed():0.0#}, Pace: {CalcPace():0.0#} min per mile";
        }
        return getSummaryString;
    }


    public double GetLengthMin()
    {
        return _lengthMin;
    }


    public string GetDate()
    {
        return _date;
    }
}