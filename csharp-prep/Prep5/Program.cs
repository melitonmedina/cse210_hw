using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareValue = SquareNumber(number);
        
        //Displaying the results
        DisplayResults(name, squareValue);


       
    }

    // beginning of created functions

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    
    static string PromptUserName()
    {
        Console.Write($"Please enter your name: ");
        string name = Console.ReadLine();

        return(name);
    }

    static int PromptUserNumber()
    {
        Console.Write($"Please enter you favorite number :");
        int number = int.Parse(Console.ReadLine());
        
        return(number);
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;

        return(squared);
    }

    static void DisplayResults(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

}