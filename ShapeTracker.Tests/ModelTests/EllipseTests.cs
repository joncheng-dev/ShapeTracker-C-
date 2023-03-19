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
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 2;
      Ellipse newEllipse = new Ellipse(length1, 3);
      int result = newEllipse.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      Ellipse newEllipse = new Ellipse(3, 1);
      int newLength1 = 5; 
      newEllipse.Side1 = newLength1;
      Assert.AreEqual(newEllipse.Side1, newLength1);
    }
  }
}