public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private double _totalOrderPrice = 0.0;
    private double _shippingCost = 0.0;


    public Order(Customer customer)
    {
        _customer = customer;
    }


    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }


    public void CalculateTotalPrice()
    {
        if (_customer.IsBasedInUSA())
        {
            _shippingCost = 5.0;
        }

        else
        {
            _shippingCost = 35.0;
        }


        foreach (Product prd in _products)
        {
            _totalOrderPrice += prd.ComputeCost();
        }

        _totalOrderPrice += _shippingCost;
    }


    public void DisplayTotalOrderPrice()
    {
        CalculateTotalPrice();
        Console.WriteLine($"The total order price is {_totalOrderPrice}");
    }
}