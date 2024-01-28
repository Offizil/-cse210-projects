// Fraction.cs

using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }


    public int GetTop()
    {
        return _top;
    }
     
    public int GetBottom ()
    {
        return _bottom;
    }

    public void SetTop (int newTop)
    {
        _top = newTop;
    }

    public void SetBottom(int newBottom)
    {
        _bottom = newBottom;
    }

    public string GetFractionString ()
    {
        
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue ()
    {
        return (double)_top / _bottom;
    }


}
