using System.Runtime.InteropServices;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {

    }
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < stopTime)
        {
            int breathSeconds = 5;  
            bool breathIn = true;
            bool breathOut = false;
            bool doneCounting;

           
            if (breathIn)
            {
                Console.Write("\nBreath in...");
                doneCounting =ShowCountDown(breathSeconds);

                if (!doneCounting)
                {
                    Console.Write("\b \b");
                }

                if (doneCounting)
                {
                    breathOut = true;
                }

            }

            if (breathOut)
            {
                
                Console.Write("\nBreath out...");
                doneCounting =ShowCountDown(breathSeconds);
                

                if (!doneCounting)
                {
                    Console.Write("\b \b");
                }


            }

            Console.WriteLine();
            
        }
        
    }

    public override void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing");

        Console.Write("How long in seconds would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(_spinnerSeconds);

    }



    public override void DisplayEndingMessage()
    {
        
        Console.WriteLine("\nWell done!!");
        ShowSpinner(_spinnerSeconds);
        Console.WriteLine($"You have completed another {_duration} seconds of the Breathing Activity");
        ShowSpinner(_spinnerSeconds);
    }




}