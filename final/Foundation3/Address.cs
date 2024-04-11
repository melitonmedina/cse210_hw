    public class Address
{
    private string _street = "";
    private string _city = "";
    private string _stateProvidence = "";
    private string _country = "";
    
    public Address(string street, string city, string stateProvidene, string country)
    {
        _street = street;
        _city = city;
        _stateProvidence = stateProvidene;
        _country = country;

    }

    public string GetAddress()
    {
        string address = $"       {_street}\n       {_city}, {_stateProvidence}\n       {_country}";

        return address;
    }

}