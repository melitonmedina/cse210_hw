using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    protected List<int> _controlPromptList = new List<int>();
    protected List<int> _tempPromptList = new List<int>();
    protected string _promptString = "";
    protected string _description;
    protected int _duration;
    protected int _spinnerSeconds = 5;
    protected Random _randomPrompt = new Random();

    public Activity()
    {

    }

    // these clases are abstract classes
    public abstract void DisplayStartingMessage();
    
        
    public abstract void DisplayEndingMessage();

    // end of abstract classes
    


    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = ["|", "/", "-", "\\", "|","/", "-", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b \b");

            i++;
            if (i >= spinnerAnimation.Count)
            {
                i = 0;
            }
           
        }
        Console.WriteLine();

    }


    public bool ShowCountDown(int seconds)
    {
        bool doneCounting = false;
        int i = seconds;
        while ( i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;

        }

        doneCounting = true;

        return doneCounting;
    }

}