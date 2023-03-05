using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(3,4,5);
      Console.WriteLine($"Side one is: {testTriangle.Side1}");
      Console.WriteLine($"Side two is: {testTriangle.Side2}");
      Console.WriteLine($"Side three is: {testTriangle.Side3}");
      Console.WriteLine("Calculating type of triangle..");
      Console.WriteLine($"Triangle type: {testTriangle.CheckType()}.");
    }
  }
}

