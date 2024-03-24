using System;
using System.ComponentModel;
using System.Configuration.Assemblies;
public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> words = new List<Word>();
    private List<int> controlListHide = new List<int>();
    private List<int> tempListHide = new List<int>();
    private Random _random;
    private bool _isComplete = false;


    public Scripture(Reference reference , string text)
    {
        _reference = reference;
        _random = new Random();

        string [] tempWords = text.Split(" ");

        int i = 0;
        foreach (string eachWord in tempWords)
        {
            
            words.Add(new Word(eachWord));
            controlListHide.Add(i);
            i++;
        }

    }

    public void HideRandomWords(int numToHide)
    {
        int j = 0;
        int k = 0;

        while ((j <= numToHide - 1) & (controlListHide.Count > k))
        {
            int index = _random.Next(0, words.Count());
            bool included = tempListHide.Contains(index);
            if (included == false)
            {
                tempListHide.Add(index);
                controlListHide.Remove(index);
                words[index].Hide();
                j++;
            }

        }

    }

    public string GetDisplay()
    {
        string scriptureDisplay = "";
        string referenceDisplay = "";
        List<string> oneWord = new List<string>();

        for (int i = 0; i < words.Count; i++)

        {
            oneWord.Add(words[i].GetDisplay());

        }

        referenceDisplay = _reference.GetDisplay();
        scriptureDisplay = string.Join(" ", oneWord);
        return referenceDisplay  + " " + scriptureDisplay;

    }

    public bool IsCompletelyHidden()
    {
        if (controlListHide.Count() < 1)
        {
            _isComplete = true;
        }
        return _isComplete;
    }


}