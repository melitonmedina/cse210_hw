using System;



public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entryText = "";

    public void DisplayEntry()
    {

        Console.WriteLine($"Date: {_date} - {_prompt}\n{_entryText}\n");



    }
    





}