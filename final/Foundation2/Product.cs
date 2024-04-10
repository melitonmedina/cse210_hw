public class Product
{
    private string _productName = "";
    private string _productId = "";
    private double _price = 0.0;
    private int _quantity = 0;

    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;

    }


    public double ComputeCost()
    {
        return _price * _quantity;
    }


    public string GetProductName()
    {
        return _productName;
    }


    public string GetProductId()
    {
        return _productId;
    }


    public int GetQuantity()
    {
        return _quantity;
    }


    public double GetPrice()
    {
        return _price;
    }
}