using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Triangle testTriangle = new Triangle(3,4,5);
      Console.WriteLine($"Side one is: {testTriangle.GetSide1()}");
      Console.WriteLine($"Side two is: {testTriangle.GetSide2()}");
      Console.WriteLine($"Side three is: {testTriangle.GetSide3()}");
      Console.WriteLine("Calculating type of triangle..");
      Console.WriteLine($"Triangle type: {testTriangle.CheckType()}.");
      Console.WriteLine("Updating sides...");
      testTriangle.SetSide1(44);
      testTriangle.SetSide2(44);
      testTriangle.SetSide3(70);
      Console.WriteLine($"The triangle's sides are now {testTriangle.GetSide1()}, {testTriangle.GetSide2()}, and {testTriangle.GetSide3()}");
      Console.WriteLine($"Now the triangle is: {testTriangle.CheckType()}.");
    }
  }
}

