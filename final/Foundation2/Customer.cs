public class Customer
{
    private string _customerName = "";
    private Address _address;

    private bool _isLocationUSA = false;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }


    public bool IsBasedInUSA()
    {
        _isLocationUSA = _address.IsBasedInUSA();
        return _isLocationUSA;
    }


    public string GetCostumerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}