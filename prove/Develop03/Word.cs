public class Word
{
    private string _text;
    private string _maskText;
    private bool _isHidden;


    // public Word()
    // {

        
    // }
    public Word(string text)
    {
        _text = text;
        _maskText = text;
        _isHidden = false;


    }

    public void Hide()
    {
        _isHidden = true;
        string replaceChar = "_";
        _maskText = string.Concat(Enumerable.Repeat(replaceChar, _text.Length)); // https://stackoverflow.com/questions/532892/can-i-multiply-a-string-in-c

    }

    public void Show()
    {
        _isHidden = false; 
        _maskText = _text;    

    }

    public bool IsHidden()
    {
        bool isHidden = _isHidden;

        return isHidden;
    }

    public string GetDisplay()
    {
        string textToReturn  = _maskText;
        return textToReturn;


    }




}