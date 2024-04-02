public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private string _questionString = "";
    private List<int> _controlQuestionList = new List<int>();
    private List<int> _tempQuestionList = new List<int>();
    //private Random _randomPrompt = new Random();
    private Random _randomQuestion = new Random();

    public ReflectingActivity()
    {

    }
    public void Run()
    {
        GetRandomPrompt();
        DisplayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < stopTime)
        {
            GetRandomQuestion();
            DisplayQuestion();
        }

    }
    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you wanted to give up but you didn't");
        _prompts.Add("Think of a time when you took accountability for a mistake");
        _prompts.Add("Think of a time when you helped someone in need");
        _prompts.Add("Think of a time when you defended your beliefs");
        _prompts.Add("Think of a time when you shared your testimony of the Savior");
        _prompts.Add("Think of a time when you stood for someone else");
        _prompts.Add("Think of a time when you achieved a worthy goal");

        if (_tempPromptList.Count == 0)
        {
            _controlPromptList = Enumerable.Range(0, _prompts.Count).ToList();
            
        }

        _tempPromptList = _controlPromptList;
        int[] arrPrompts = _tempPromptList.ToArray();       
        int[] indexPrompt = _randomPrompt.GetItems(arrPrompts, 1); // much cleaner and faster way to get an unrepeated random number.

        _controlPromptList.Remove(indexPrompt[0]);
        _promptString = _prompts[indexPrompt[0]];

        return _promptString;
                     
    }
    
    
    public string GetRandomQuestion()
    {
        _questions.Add("What was learned through this experience?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("How did you get started?");
        _questions.Add("What made this a successful accomplishment?");
        _questions.Add("How can you take what was learned with you and apply it to other circumstances?");
        _questions.Add("What contributed to your keeping moving on?");
        _questions.Add("Have you ever done anything like this before?");

        if (_tempQuestionList.Count == 0)
        {
            _controlQuestionList = Enumerable.Range(0, _questions.Count).ToList();
       
        }

        _tempQuestionList = _controlQuestionList;
        int[] arrQuestions = _tempQuestionList.ToArray();       
        int[] indexQuestion = _randomQuestion.GetItems(arrQuestions, 1); // much cleaner and faster way to get an unrepeated random number.

        _controlQuestionList.Remove(indexQuestion[0]);
        _questionString = _questions[indexQuestion[0]];


        return _questionString;
    }



    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {_promptString} ---");
        Console.WriteLine("\nWhen you have somethng in mind press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions as they relate to this experience.");

        Console.Write("\nYou may begin in: ");
        bool doneCounting = ShowCountDown(5);

        if (doneCounting)
        {
            Console.Clear();
        }


    }
    public void DisplayQuestion()
    {
        Console.Write($"> {_questionString} ");
        ShowSpinner(10);
    }

    public override void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

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
        Console.WriteLine($"You have completed another {_duration} seconds of the Reflecting Activity");
        ShowSpinner(_spinnerSeconds);
    }
}