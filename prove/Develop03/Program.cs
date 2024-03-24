// for creativity this program will not hide the same words that have already been hidden.
using System;
class Program
{
    static void Main(string[] args)
    {
        int numToHide = 3;
        bool isComplete = false;
        Reference ref1 = new Reference("3Nephi", 27, 20);

        string scriptureText = "Now this is the commandment: Repent, all ye ends of the earth, and come unto me and be baptized in my name, that ye be sanctified by the reception of the the Holy Ghost, that ye may stand spotless before me at the last day.";

        Scripture script1 = new Scripture(ref1, scriptureText);

        Console.Clear();
        string userAnswer = "go on";

        //create a list of indexes for word hidding
        List<string> wordsToHide = new List<string>();

        while ((userAnswer.ToLower() != "quit") & (isComplete == false))
        {
            Console.Clear();
            //Thread.Sleep(100);
            Console.WriteLine(script1.GetDisplay());
            isComplete = script1.IsCompletelyHidden();
            Console.WriteLine("\nPlease press enter to continue or type 'quit' to finish");
            userAnswer = Console.ReadLine();
            script1.HideRandomWords(numToHide);
            
            //numToHide ++;

        }
    
    
        

    }


}