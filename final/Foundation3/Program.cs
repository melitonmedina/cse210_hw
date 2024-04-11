using System;

class Program
{
    static void Main(string[] args)
    {
        // lecture event
        Console.WriteLine($"\n-----------------------------------------");
        Lecture lecture = new Lecture("Lecture", "Principles of Modern Physics", "New and emerging theories a jaw-dropping approach", "05-27-2024", "5:00 PM", new Address("1200 Washington Ave.", "New York City", "NY", "USA"), "Dr. Lewis", 300);

        Console.WriteLine($"{lecture.MessageFullDetails()}\n");
        Console.WriteLine($"{lecture.MessageStandardDetails()}\n");
        Console.WriteLine($"{lecture.MessageShortDescription()}\n");




        // Reception event
        Console.WriteLine($"\n-----------------------------------------");
        Reception reception = new Reception("Reception", "Live Country Band & Diner", "Come and enjoy an evening of music and delicious food", "07-02-2024", "4:00 PM", new Address("3300 Fun Ave.", "Huston", "TX", "USA"), "event_rsvp@gmail.com");

        Console.WriteLine($"{reception.MessageFullDetails()}\n");
        Console.WriteLine($"{reception.MessageStandardDetails()}\n");
        Console.WriteLine($"{reception.MessageShortDescription()}\n");




        //Outdoor gathering
        Console.WriteLine($"\n-----------------------------------------");
        Outdoor outdoor = new Outdoor("Outdoor Gathering", "Water Games", "Get your summer tan going at this the biggest summer water day!", "07-15-2024", "11:00 AM - 5:00 PM", new Address("1000 Water Park Rd.", "Miami", "FL", "USA"), "Sunny & with clear skies 81°F");

        Console.WriteLine($"{outdoor.MessageFullDetails()}\n");
        Console.WriteLine($"{outdoor.MessageStandardDetails()}\n");
        Console.WriteLine($"{outdoor.MessageShortDescription()}\n");

    }
}