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


    public double CalculateTotalPrice()
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

        return _totalOrderPrice += _shippingCost;
    }


    public void DisplayTotalOrderPrice()
    {
        CalculateTotalPrice();
        Console.WriteLine($"The total order price is {Math.Round(_totalOrderPrice, 2)}");
    }


    public string GetPackingLabel()
    {
        List<string> packing = new List<string>();
        
       int i = 0; 
       foreach (Product prd in _products)
       {
            // string productName = 
            packing.Add($"{i + 1}.{prd.GetProductName()} - ID: {prd.GetProductId()}");
            i +=1;
       }
       string [] packingArray = packing.ToArray();
       string packingLabel = string.Join("\n", packingArray);

       return "Product:\n" + packingLabel;
    }


    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer:{_customer.GetCostumerName()}\nAddress:\n{_customer.GetAddress()}";
        return shippingLabel;

    }
}