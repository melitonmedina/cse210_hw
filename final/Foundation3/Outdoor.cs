public class Outdoor : Event
{
    private string _weather = "";


    public Outdoor(string eventType, string title, string description, string date, string time, Address address, string weather): base(eventType, title, description, date, time, address)
    {
        _weather = weather;
    }
    public override string MessageFullDetails()
    {
        string standardDetails = MessageStandardDetails();
        string fullDetails = $"{standardDetails}\nWeather Forcast: {_weather}";

        return fullDetails;
    }

    public override string MessageShortDescription()
    {
        string title = GetTitle();
        string date = GetDate();
        string shortDescription = $"Evetn Type: {GetEventType()}\nTitle: {title}\nDate: {date}";
        return shortDescription;
    }
}
