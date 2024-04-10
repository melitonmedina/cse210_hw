using System;

class Program
{
    static void Main(string[] args)
    {
        // //first order
        Order order1 = new Order(new Customer("Pressure Tubing, LLC", new Address("1200 Belmont Dr.", "Somerset", "NC", "USA")));
        order1.AddProduct("Pressure Tubes", "1215", 250.12, 27);
        order1.AddProduct("Sheath Tubes", "1020", 310.50, 70);
        string packingLabel = order1.GetPackingLabel();
        string shippingLabel = order1.GetShippingLabel();
        double totalPrice = order1.CalculateTotalPrice();
        Console.WriteLine("\nThis is Order 1:");
        Console.WriteLine($"Packing Label:\n{packingLabel}\n\nShipping Label:\n{shippingLabel}\nThe total cost is ${Math.Round(totalPrice, 2)}");


        // //second order
        Console.WriteLine();
        Order order2 = new Order(new Customer("Micro Stamping, LC", new Address("2235 Main Rd.", "Elizabeth", "NJ", "USA")));
        order2.AddProduct("Large scisors", "L12", 25.99, 35);
        order2.AddProduct("Medium scisors", "M10", 52.50, 45);
        order2.AddProduct("Small scisors", "S03", 37.50, 15);
        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();
        double totalPrice2 = order2.CalculateTotalPrice();
        Console.WriteLine("\nThis is Order 2:");
        Console.WriteLine($"Packing Label:\n{packingLabel2}\n\nShipping Label:\n{shippingLabel2}\nThe total cost is ${Math.Round(totalPrice2, 2)}");

        // //third order
        Order order3 = new Order(new Customer("Windows", new Address("2300 French Cr.", "Paris", "Île-de-France", "France")));
        order3.AddProduct("Outdoor window", "W-5522", 750.45, 5);
        order3.AddProduct("Indood window", "W-1010", 500.99, 12);
        string packingLabel3 = order3.GetPackingLabel();
        string shippingLabel3 = order3.GetShippingLabel();
        double totalPrice3 = order3.CalculateTotalPrice();
        Console.WriteLine("\nThis is Order 3:");
        Console.WriteLine($"Packing Label:\n{packingLabel3}\n\nShipping Label:\n{shippingLabel3}\nThe total cost is ${Math.Round(totalPrice3, 2)}");
        
    }
}