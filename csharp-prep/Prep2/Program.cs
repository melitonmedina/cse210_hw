using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter you grade percentage: ");
        string letterPercentage = Console.ReadLine();
        int numberPercentage = int.Parse(letterPercentage);

        // the sign
        string plus = "+";
        string minus = "-";
        string message;
        

    

        // new letter variable
        string letter;
    

        // Beginning of if, else if, and else statements part 1 and 3

        if (numberPercentage >= 90)
        {
            letter = "A";
        }

        else if (numberPercentage >= 80)
        {

             letter = "B";;
        }

        else if (numberPercentage >= 70)
        {

             letter = "C";
        }

        else if (numberPercentage >= 60)
        {

             letter = "D";;
        }

        else
        {

             letter = "F";
        }

        //Console.WriteLine(letter);

        // part 2

        if (numberPercentage >= 70)
        {
            //Console.WriteLine("Congratulations you passed the course!");
            message = "Congratulations you passed the course!";
        }

        else 
        {
            //Console.WriteLine("You did a good job, but did not meet the passing grade.");
            message = "You did a good job, but did not meet the passing grade. Next time you will make it!";
        }

        // Stretch challenge determining the letter sign
        if (numberPercentage % 10 >= 7 && letter != "A" && letter != "F")
        {
            Console.WriteLine($"{letter} {plus}");

        }
        else if (numberPercentage % 10 < 3 && letter != "F")
        {
            Console.WriteLine($"{letter} {minus}");
        }
        else
        {
            Console.WriteLine(letter);
                
        }
        Console.WriteLine(message);
    



    }
}