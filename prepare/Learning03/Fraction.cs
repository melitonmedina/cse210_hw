public class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        

    }

    public Fraction(int whole)
    {
        _top = whole;
        _bottom =  1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    
    }

    public void getTop()
    {
        Console.WriteLine($"{_top}");
    }

    public  void SetTop(int top)
    {
        _top = top;


    }

    public void GetBottom()
    {
        Console.WriteLine($"{_bottom}");

    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;


    }

    public string GetFractionString()
    {
        return (_top.ToString() + "/" + _bottom.ToString());

    }

    public double GetDecimalValue()
    {

        return (double)_top /(double)_bottom;
    }


}
