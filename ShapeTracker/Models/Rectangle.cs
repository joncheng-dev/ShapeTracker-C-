namespace ShapeTracker.Models
{
  public class Rectangle
  {
    private int _side1;
    
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }

    public int Side2 { get; set; }

    public Rectangle( int length1, int length2)
    {
      _side1 = length1;
      Side2 = length2;
    }

    public int CalculateRectangleArea()
    {
      return _side1 * Side2;
    }
  }
}