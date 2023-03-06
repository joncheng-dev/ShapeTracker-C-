using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker App!");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");

      Console.WriteLine("Enter length of 1st side:");
      string strNumber1 = Console.ReadLine();
      Console.WriteLine("Enter length of 2nd side:");
      string strNumber2 = Console.ReadLine();
      Console.WriteLine("Enter length of 3rd side:");
      string strNumber3 = Console.ReadLine();

      int length1 = int.Parse(strNumber1);
      int length2 = int.Parse(strNumber2);
      int length3 = int.Parse(strNumber3);

      Triangle tri = new Triangle(length1, length2, length3);
    }
  }
}

