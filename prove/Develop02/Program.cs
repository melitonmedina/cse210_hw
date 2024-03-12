using System;
using System.Configuration.Assemblies;
using System.Xml.Serialization;

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
        int index =  0;
        //Console.WriteLine(choice);
        while (choice != "5")
        {
            choice = DisplayMenu();
            
            //UseChoice(choice);
            switch(choice)
        
            {
                case "1":
                
                PromptGenerator genPrompt = new PromptGenerator();
                thePrompt = genPrompt.GetRandomPrompt();
                Console.Write($"{thePrompt} \n> ");
                string answer = Console.ReadLine();
                //Console.WriteLine(answer);


                //DateTime dateTime = DateTime.Now;
                DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);


                newEntry._date = dateOnly.ToString();
                newEntry._prompt = thePrompt;
                newEntry._entryText = answer;
                //oneEntry.Insert(index, newEntry);
                
                journal.AddEntry(newEntry);
                //index++ ;
                //Console.WriteLine(index);
                //Console.WriteLine(newEntry._prompt);
                
                //Console.WriteLine(newEntry);
                           
                break;

                
            
                case "2":
                journal.DisplayAll();
                break;

                case "3":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                //journal.LoadFromFile(filename);
                break;

                case "4":
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                //journal.SaveToFile(filename);
                break;

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