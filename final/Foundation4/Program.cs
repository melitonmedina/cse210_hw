using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("25 Jun 2024", 50.0, 3.5);
        activities.Add(running);

        Cycling cycling = new Cycling("06 Apr 2024", 30.0, 12.0);
        activities.Add(cycling);

        Swimming swimming = new Swimming("10 Dec 2024", 120.0, 100);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            string summary = activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}