using System.IO.Compression;
using System.Net.NetworkInformation;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    
    
    public ListingActivity()
    {

    }
    public void Run()
    {
        GetRandomPrompt();       
        List<string> userAnswers = GetListFromUser();
        
        _count = 0;

        foreach (string answer in userAnswers)
        {
            _count += 1;
           
        }
        if (_count < 2)
        {
            Console.WriteLine($"You listed {_count} item");
        }
        else
        {
            Console.WriteLine($"You listed {_count} items");
        }
        
    }



    public void GetRandomPrompt()
    {
        _prompts.Add("What are the highlights of this week?");
        _prompts.Add("Who were some of friends growing up?");
        _prompts.Add("What cities would you like to visit?");
        _prompts.Add("When have you felt the happiest this month?");
        _prompts.Add("What are your favorite icecream flavors");

        if (_tempPromptList.Count == 0)
        {
            _controlPromptList = Enumerable.Range(0, _prompts.Count).ToList();
            
        }

        _tempPromptList = _controlPromptList;
        int[] arrPrompts = _tempPromptList.ToArray();       
        int[] indexPrompt = _randomPrompt.GetItems(arrPrompts, 1); // much cleaner and faster way to get an unrepeated random number.

        _controlPromptList.Remove(indexPrompt[0]);
        _promptString = _prompts[indexPrompt[0]];

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_promptString} ---");
        Console.Write("\nYou may begin in: ");
        bool doneCounting = ShowCountDown(5);
        Console.WriteLine();

    }




    public List<string> GetListFromUser()
    {
        List<string> userAnswers = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < stopTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            userAnswers.Add(answer);   
        }
        
        return userAnswers;
    }




    public override void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

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
        Console.WriteLine($"You have completed another {_duration} seconds of the Listing Activity");
        ShowSpinner(_spinnerSeconds);

    }
}