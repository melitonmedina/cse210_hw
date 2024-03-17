using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    Random randomGenerator = new Random();
    


    public (string, int) GetRandomPrompt()
    {
        //int prevRandom = _prompts.Count + 1;
        //int randomPrompt = 0;
        //string thePrompt ="";

        _prompts.Add("What made me the happiest today?");
        _prompts.Add("How did I see the hand of God this day?");
        _prompts.Add("How can I show more appriciation towards others?");
        _prompts.Add("What was the most challenging thing I faced today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("How can I lay a better foundation for my future?");
        _prompts.Add("How would I like be to remembered?");

        
        int randomPrompt = randomGenerator.Next(0 , _prompts.Count);
        //Console.WriteLine(_prompts.Count());
        //Console.WriteLine(_prompts.Count);
        int currentPrompt = randomPrompt;
        string thePrompt = _prompts.ElementAt(randomPrompt);

        return (thePrompt, currentPrompt) ;

    }











}