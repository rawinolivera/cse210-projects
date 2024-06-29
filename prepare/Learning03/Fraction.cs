using System.IO.Pipes;

class Fraction
{
  private int _top;
  private int _bottom;
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
    _top = top;
    _bottom = bottom;
  }

  public string GetFractionString()
  {
    string fractionStr = $"{_top}/{_bottom}";
    return fractionStr;
  }

  public double GetDecimalValue()
  {
    double decimalVal = (double)_top / (double)_bottom;
    return decimalVal;
  }
}