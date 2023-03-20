using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class EllipseTests
  {
    [TestMethod]
    public void EllipseConstructor_CreatesInstanceOfEllipse_Ellipse()
    {
      Ellipse newEllipse = new Ellipse(1, 4);
      Assert.AreEqual(typeof(Ellipse), newEllipse.GetType());
    }

    [TestMethod]
    public void GetNumber1_ReturnsNumber1_Int()
    {
      int length1 = 2;
      Ellipse newEllipse = new Ellipse(length1, 3);
      int result = newEllipse.Number1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetNumber1_SetsValueOfNumber1_Void()
    {
      Ellipse newEllipse = new Ellipse(3, 1);
      int newLength1 = 5; 
      newEllipse.Number1 = newLength1;
      Assert.AreEqual(newEllipse.Number1, newLength1);
    }

    [TestMethod]
    public void GetNumber2_ReturnsNumber2_Int()
    {
      int length2 = 5;
      Ellipse newEllipse = new Ellipse(2, length2);
      int result = newEllipse.GetNumber2();
      Assert.AreEqual(result, length2);
    }
  }
}