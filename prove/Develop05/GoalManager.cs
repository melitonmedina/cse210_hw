using System;
using System.Text.RegularExpressions;
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

        Console.WriteLine("Menu options:");
        Console.WriteLine($"    {opt1}\n    {opt2}\n    {opt3}\n    {opt4}\n    {opt5}\n    {opt6}");

        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        return choice;

    }

    public void DisplayPlayerInfo()
    {
        if (_score < 1000)
        {
            Console.Write("\nLevel White Belt: ");
        }

        else if (_score < 2000)
        {
            Console.Write("\nLevel Yellow Belt: ");
            
        }

        else if (_score < 3000)
        {
            Console.Write("\nLevel Orange Belt: ");
        }

        else if (_score < 4000)
        {
            Console.Write("\nLevel Green Belt: ");
        }

        else if (_score < 5000)
        {
            Console.Write("\nLevel Blue Belt: ");
        }

        else if (_score < 10000)
        {
            Console.Write("\nLevel Purple Belt: ");
        }

        else if (_score < 12000)
        {
            Console.Write("\nLevel Red Belt: ");
        }

        else if (_score < 15000)
        {
            Console.Write("\nLevel Brown Belt: ");
        }

        else
        {
            Console.Write("\nLevel Black Belt: ");
        }


        Console.Write($"You have {_score} points.\n");
        Console.WriteLine();
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
        bool saveToFile = false;
        foreach (Goal oneGoal in _goals)
        {
            string rep1 = oneGoal.GetStringRepresentation(saveToFile);
            Console.WriteLine(rep1);
        }

    }


    public void CreateGoals()
    {
        string goalType = "";
        string goalName = "";
        string goalDesciption = "";
        string goalPoints = "";
        string target = "";
        string bonus = "";
        string goalChoice = DisplayGoalChoice();

        if (goalChoice == "1") // simple goal
        {
            goalType = "Simple Goal";

            Console.Write("What is the name of your goal? ");
            goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            goalDesciption = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            goalPoints = Console.ReadLine();


            SimpleGoal simple = new SimpleGoal(goalType, goalName, goalDesciption, goalPoints);

            _goals.Add(simple);
        }


        if (goalChoice == "2")
        {
            goalType = "Eternal Goal";

            Console.Write("What is the name of your goal? ");
            goalName = Console.ReadLine();

            Console.Write("What is a short desciption of it? ");
            goalDesciption = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            goalPoints = Console.ReadLine();


            EternalGoal eternal = new EternalGoal(goalType, goalName, goalDesciption, goalPoints);

            _goals.Add(eternal);

        }


        if (goalChoice == "3")
        {
            goalType = "Checklist Goal";

            Console.Write("What is the name of your goal? ");
            goalName = Console.ReadLine();

            Console.Write("What is a short desciption of it? ");
            goalDesciption = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            goalPoints = Console.ReadLine();

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            target = Console.ReadLine();

            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = Console.ReadLine();


            CheckListGoal checklist = new CheckListGoal(goalType, goalName, goalDesciption, goalPoints, target, bonus);

            _goals.Add(checklist);
        }
    
    }


    public string DisplayGoalChoice()
    {
        string opt1 = "1. Simple Goal";
        string opt2 = "2. Eternal Goal";
        string opt3 = "3. Checklist Goal";

        Console.WriteLine("The types of goals are:");
        Console.WriteLine($"    {opt1}\n    {opt2}\n    {opt3}");

        Console.Write("Which type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();

        return goalChoice;
        
    }

    public void RecordEvent()
    {
        if (_goals.Count > 0)
        {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        _recordIndex = Convert.ToInt32(Console.ReadLine());
        _goals[_recordIndex - 1].RecordEvent();

        // make sure to keep track of the total points
        int tempScore = _goals[_recordIndex - 1].GetPointsAdder();
        _score += tempScore;
        Console.WriteLine($"Congratulations! You have earned {tempScore} points!");
        Console.WriteLine($"You now have {_score}");

        }
        else
        {
            Console.WriteLine("You have not listed any goals yet. Please create a new goal before selecting this option.");
        }

    }


    public void SaveGoals()
    {
        List <string> stringsToSave = new List<string>(); //create a list of string to hold the elements of the goal object
        bool saveToFile = true;
       

        foreach (Goal goal in _goals)
        {
            string stringGoal = goal.GetStringRepresentation(saveToFile);
            stringsToSave.Add(stringGoal);
        }
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        // let's call the streamWriter class and save the data
        using (StreamWriter goalFile = new StreamWriter(fileName))
        {
            goalFile.WriteLine(_score.ToString());

            foreach (string goal in stringsToSave)
            {
                goalFile.WriteLine(goal);
            }
        }


    }


    public void LoadGoals()
    {
        _goals.Clear(); // avoids duplicating goals current goals
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string [] lines =System.IO.File.ReadAllLines(fileName);

        
        foreach(string line in lines)
        {
            string [] parts = line.Split(new string [] {":","~~"}, StringSplitOptions.None);

            if(parts.Count() < 2)
            {
                _score = Convert.ToInt32(parts[0]);
            }

            if (parts[0].ToLower() == "simple goal")
            {
                SimpleGoal simple = new SimpleGoal(parts[0], parts[1], parts[2], parts[3], parts[4]);
                _goals.Add(simple);
            }

            if (parts[0].ToLower() == "eternal goal")
            {
                EternalGoal eternal = new EternalGoal(parts[0], parts[1], parts[2], parts[3]);
                _goals.Add(eternal);
            }

            if (parts[0].ToLower() == "checklist goal")
            {
                CheckListGoal checkList = new CheckListGoal(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                _goals.Add(checkList);
            }
        }

    }



}