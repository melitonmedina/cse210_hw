using System;
using System.Configuration.Assemblies;
using System.Xml.Serialization;

// for creativity the program will not repeat the same prompt in one session until all 10 prompts have been displayed randomly displayed first.

class Program
{
    static void Main(string[] args)
    {
        
        List<Entry> oneEntry = new List<Entry>();
        Entry newEntry = new Entry();
        Journal journal = new Journal();
        string thePrompt = "";
        string filename = "";
        string choice = "";
        int currentPromptIndex;
        bool iterate = true;

        List<int> curPrompts = new List<int>();
        curPrompts.Clear(); // clear the current list of prompts at the beginning of each new journal entry

        //Console.WriteLine(choice);
        while (choice != "5")
        {
            choice = DisplayMenu();
            
            
            
            //UseChoice(choice);
            switch(choice)
        
            {
                // write case
                case "1":
                PromptGenerator genPrompt = new PromptGenerator();
                iterate = true;
                while (iterate == true)
                {
                    genPrompt._prompts.Clear();
                    //Console.WriteLine(genPrompt._prompts.Count());
                    (thePrompt, currentPromptIndex) = genPrompt.GetRandomPrompt();
                    bool included = curPrompts.Contains(currentPromptIndex);
                    

                    if (included == false)
                    {
                        curPrompts.Add(currentPromptIndex);
                        iterate = false;
                    }
                    //Console.WriteLine(curPrompts.Count);
                    //Console.WriteLine(genPrompt._prompts.Count());

                    if (curPrompts.Count ==  genPrompt._prompts.Count()) // make sure to clear the list of current prompts when all prompts have been used up.
                    {
                        Console.WriteLine(curPrompts.Count);
                        Console.WriteLine(genPrompt._prompts.Count());
                        curPrompts.Clear();
                    }
                    

                }
                
                
                
                Console.Write($"{thePrompt} \n> ");
                string answer = Console.ReadLine();
                //Console.WriteLine(answer);
                //DateTime dateTime = DateTime.Now;
                DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
                newEntry._date = dateOnly.ToString();
                newEntry._prompt = thePrompt;
                newEntry._entryText = answer;
                journal.AddEntry(newEntry);
                break;

                //the display         
                case "2":
                journal.DisplayAll();
                break;

                // Saving to a file 
                case "3":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                break;

                // Writing to a file
                case "4":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.SaveToFile(filename);
                break;

                //Exit the journanl
                case "5":
                break;

            }


        }
            
    }

    static string DisplayMenu()
    {

        Console.Write("Please select one of the following choices: \n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\n");
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        

        return choice;

    }




}