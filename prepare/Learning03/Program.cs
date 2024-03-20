using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue() + "\n");
        // using the set method
        fract1.SetTop(10);
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract1.GetDecimalValue() + "\n");



        Fraction fract2 = new Fraction(5);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue() + "\n");
        // setting the bottom
        fract2.SetBottom(5);
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract2.GetDecimalValue() + "\n");


        Fraction fract3 = new Fraction(3 , 4);
        Console.WriteLine(fract3.GetFractionString());
        Console.WriteLine(fract3.GetDecimalValue());

        Fraction fract4 = new Fraction(1 , 3);
        Console.WriteLine(fract4.GetFractionString());
        Console.WriteLine(fract4.GetDecimalValue());



    }

}