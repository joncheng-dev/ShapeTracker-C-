using System;

namespace ShapeTracker.Models
{
  public class Ellipse
  {
    private int _radius1;
    private int _radius2;

    public int Radius1
    {
      get { return _radius1; }
      set { _radius1 = value; }
    }

    public Ellipse(int length1, int length2)
    {
      _radius1 = length1;
      _radius2 = length2;
    }

    public int GetRadius2()
    {
      return _radius2;
    }

    public void SetRadius2(int newValue)
    {
      _radius2 = newValue;
    }

    public double CalculateEllipseArea()
    {
      return Math.PI * _radius1 * _radius2;
    }
  }
}