using System.ComponentModel;

public class Reference
{
    private string  _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference()
    {
        
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 1200;
        
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;


    }

    public string GetDisplay()
    {
        string fullReference = "";
        if (_endVerse == 1200)
        {
            fullReference = $"{_book} {_chapter}: {_verse}";

        }
        else
        {
            fullReference = $"{_book} {_chapter}: {_verse}-{_endVerse}";
        }


        return fullReference;
    }







}