using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      List<Triangle> allTriangles = Triangle.GetAll();
      Triangle testTriangle = new Triangle(3, 4, 5);
      Triangle secondTriangle = new Triangle(32, 74, 75);

      Triangle.ClearAll();

      if (allTriangles.Count == 0)
      {
        Console.WriteLine("No triangles.");
      }
      else
      {
        Console.WriteLine("You have triangles!");
        Console.WriteLine("---------------------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"1st Side: {tri.GetSide1()}");
          Console.WriteLine($"2nd Side: {tri.GetSide2()}");
          Console.WriteLine($"3rd Side: {tri.GetSide3()}");
          Console.WriteLine("---------------------");
        }
      }
    }
  }
}

