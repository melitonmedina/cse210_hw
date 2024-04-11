public class Lecture : Event
{
    private string _speaker = "";
    private int _capacity;


    public Lecture(string eventType, string title, string description, string date, string time, Address address, string speaker, int capacity) :base(eventType, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }



    public override string MessageFullDetails()
    {
        string standardDetails = MessageStandardDetails();
        string fullDetails = $"{standardDetails}\nSpeaker: {_speaker}\nCapacity: {_capacity}";

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