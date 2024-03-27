using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Square sqr1 = new Square("red", 12.5);
        Circle crl1 = new Circle("blue", 7.0);
        Rectangle rect1 = new Rectangle("brown", 10.7, 5.5);
        List<Shape> shapes = new List<Shape>();

        shapes.Add(sqr1);
        shapes.Add(crl1);
        shapes.Add(rect1);

        foreach (Shape s in shapes)
        {
            Console.Write($"{s.GetColor()} ");
            Console.Write($"{s.GetArea()}\n");
        }
       
      
    }
}