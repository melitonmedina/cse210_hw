public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> words = new List<Word>();


    public Scripture(Reference reference , string text)
    {
        _reference = reference;
        string tempText = text; // will need to change later

    }

    public void HideRandomWords(int numtoHide)
    {


    }

    public string GetDisplay()
    {

        return "";

    }

    public bool IsCompletelyHidden()
    {

        return false;
    }


}