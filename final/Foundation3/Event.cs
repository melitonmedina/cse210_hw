public abstract class Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _eventType ="";
    private Address _address;

    public Event(string eventType, string title, string description, string date, string time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;

    }


    public string GetEventType()
    {
        return _eventType;
    }

    public string GetTitle()
    {
        return _title;
    }


    public string GetDescription()
    {
        return _description;
    }


    public string GetDate()
    {
        return _date;
    }


    public string GetTime()
    {
        return _time;
    }
 

    public string MessageStandardDetails()
    {
        string standardMessage = $"Title: {_title}\nDescription: {_description}\nWhen: {_date}";
        string location = _address.GetAddress();
        string standard = $"{standardMessage}\nPlace:\n{location}";
        return standard;
    }


    public abstract string MessageFullDetails();



    public abstract string MessageShortDescription();



}