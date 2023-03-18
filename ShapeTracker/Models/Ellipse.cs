namespace ShapeTracker.Models
{
  public class Ellipse
  {
    private int _side1;

    public int Side1
    {
      get { return _side1; }
    }

    public Ellipse(int length1, int length2)
    {
      _side1 = length1; 
    }
  }
}