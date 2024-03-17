using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();





    // Add entery method
    public void AddEntry( Entry newEntry)
    {
        

        _entries.Add(new Entry() {_date = newEntry._date, _prompt = newEntry._prompt, _entryText = newEntry._entryText});
       //Console.WriteLine(newEntry._date);

        

    }


    public void DisplayAll()
    {
        
        foreach (Entry entry in _entries)
        {

            entry.DisplayEntry();
            
        }



    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter entryFile = new StreamWriter(filename))
        {

            foreach (Entry entry in _entries)
            {
                entryFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");
                //Console.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");

            }



        }


    }

    public void LoadFromFile(string filename)
    {
        string [] lines = File.ReadAllLines(filename);
        Entry fileEntry = new Entry();
        _entries.Clear(); // make sure to remove all elements from the entries list

        {

            foreach (string line in lines)
            {
                string [] variables = line.Split("~~");
                fileEntry._date = variables[0];
                fileEntry._prompt = variables[1];
                fileEntry._entryText = variables[2];

                //Console.WriteLine($"{fileEntry._date} # {fileEntry._prompt} # {fileEntry._entryText}");

                AddEntry(fileEntry);
            
            }

        }



    }








}