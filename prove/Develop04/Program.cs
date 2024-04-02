// implemented a different way of avoiding repeating the same prompt or question throughout the program during the current session. This method is faster than previous implementations.
using System;

class Program
{
    static void Main(string[] args)
    {
        
        string choice = "";
        BreathingActivity breath = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectingActivity reflect = new ReflectingActivity();

        while (choice != "4")
        {
            choice = DisplayMenu();

            if (choice == "1")
            {
                breath.DisplayStartingMessage();
                breath.Run();
                breath.DisplayEndingMessage();
            }
            
            if (choice == "2")
            {
                reflect.DisplayStartingMessage();
                reflect.Run();
                reflect.DisplayEndingMessage();
            }

            if (choice == "3")
            {
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }

        }
            
            
    }

       static string DisplayMenu()
    {
        Console.Clear();
        Thread.Sleep(1000);
        Console.Clear();
        string opt1 = "1. Start breathing activity";
        string opt2 = "2. Start reflecting activity";
        string opt3 = "3. Start listing activity";
        string opt4 = "4. Quit";
        Console.WriteLine("Menu Options:");
        Console.WriteLine($"    {opt1}\n    {opt2}\n    {opt3}\n    {opt4}");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        return choice;

    }


}