using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;


public class Journal
{
    List<Entry> _entries = new List<Entry>();





    // Add entery method
    public void AddEntry( Entry newEntry, int index)
    {

        _entries.Add(newEntry);
       //Console.WriteLine(newEntry._date);


    }


    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {

            entry.DisplayEntry();
            
        }



    }

    public void SaveToFile(string file)
    {


    }

    public void LoadFromFile(string file)
    {



    }








}