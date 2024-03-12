using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class PromptGenerator()
{
    List<string> _prompts = new List<string>();
    Random randomGenerator = new Random();
    


    public string GetRandomPrompt()
    {

        _prompts.Add("What made you the happiest today?");
        _prompts.Add("How you see the hands of God this day?");
        _prompts.Add("How can you show more appriciation towards others");
        _prompts.Add("What is the most challenging thing faced today");
        _prompts.Add("Is there anything you did that you would rather change");

        int randomPrompt = randomGenerator.Next(0 , 4);
        string thePrompt = (_prompts.ElementAt(randomPrompt));

        return thePrompt;

    }











}