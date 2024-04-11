public class Reception : Event
{
    private string _rsvp = "";


    public Reception(string eventType, string title, string description, string date, string time, Address address, string rsvpEmail ): base(eventType, title, description, date, time, address )
    {
        _rsvp = rsvpEmail;

    }


    public override string MessageFullDetails()
    {
        string standardDetails = MessageStandardDetails();
        string fullDetails = $"{standardDetails}\nPlease RSVP @: {_rsvp}";

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
