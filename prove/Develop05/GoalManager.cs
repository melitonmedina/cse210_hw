public class GoalManager
{
    protected List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _recordIndex = -1;

    public GoalManager()
    {

      
    }


    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            choice = DisplayMenu();
            if (choice == "1")
            {
                CreateGoals();
            }

            if (choice == "2")
            {
                ListGoalDetails();
            }

            if (choice == "3")
            {
                SaveGoals();
            }

            if (choice == "4")
            {
                LoadGoals();
            }

            if (choice == "5")
            {
                RecordEvent();
            }

        }

    }


    public string DisplayMenu()
    {

        string opt1 = "1. Create a new goal";
        string opt2 = "2. List goals";
        string opt3 = "3. Save goals";
        string opt4 = "4. Load goals";
        string opt5 = "5. Record event";
        string opt6 = "6. Quit";

        Console.WriteLine("Menu Options:");
        Console.WriteLine($"    {opt1}\n    {opt2}\n    {opt3}\n    {opt4}\n    {opt5}\n    {opt6}");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        return choice;

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"{_score}");
    }


    public void ListGoalNames()
    {
        int i = 0;
        foreach (Goal goal in _goals)
        {
           string name = goal.GetName();
           Console.WriteLine($" {i + 1}. {name}");
           i++;
        }

    }


    public void ListGoalDetails()
    {
        foreach (Goal oneGoal in _goals)
        {
            string rep1 = oneGoal.GetStringRepresentation();
            Console.WriteLine(rep1);
        }

    }


    public void CreateGoals()
    {
        string goalChoice = GoalChoice();
        if (goalChoice == "1") // simple goal
        {
            string goalType = "Simple Goal";

            Console.Write("What is the of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is short desciption of it? ");
            string goalDesciption = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string goalPoints = Console.ReadLine();


            SimpleGoal simple = new SimpleGoal(goalType, goalName, goalDesciption, goalPoints);

            _goals.Add(simple);



        }
    
    }


    public string GoalChoice()
    {
        string opt1 = "1. Simple Goal";
        string opt2 = "2. Eternal Goal";
        string opt3 = "3. Checklist Goal";

        Console.WriteLine("Menu Options:");
        Console.WriteLine($"    {opt1}\n    {opt2}\n    {opt3}\n");

        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        return goalChoice;
        
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplished? ");
        _recordIndex = Convert.ToInt32(Console.ReadLine());
        _goals[_recordIndex - 1].RecordEvent();

        // make sure to keep track of the total points
        _score += _goals[_recordIndex].GetPointsAdder();

       

    }


    public void SaveGoals()
    {

    }


    public void LoadGoals()
    {

    }



}