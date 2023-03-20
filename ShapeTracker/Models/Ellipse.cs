namespace ShapeTracker.Models
{
  public class Ellipse
  {
    private int _number1;
    private int _number2;

    public int Number1
    {
      get { return _number1; }
      set { _number1 = value; }
    }

    public Ellipse(int length1, int length2)
    {
      _number1 = length1;
      _number2 = length2;
    }

    public int GetNumber2()
    {
      return _number2;
    }
  }
}