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
    public void GetRadius1_ReturnsRadius1_Int()
    {
      int length1 = 2;
      Ellipse newEllipse = new Ellipse(length1, 3);
      int result = newEllipse.Radius1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetRadius1_SetsValueOfRadius1_Void()
    {
      Ellipse newEllipse = new Ellipse(3, 1);
      int newLength1 = 5; 
      newEllipse.Radius1 = newLength1;
      Assert.AreEqual(newEllipse.Radius1, newLength1);
    }

    [TestMethod]
    public void GetRadius2_ReturnsRadius2_Int()
    {
      int length2 = 5;
      Ellipse newEllipse = new Ellipse(2, length2);
      int result = newEllipse.GetRadius2();
      Assert.AreEqual(result, length2);
    }

    [TestMethod]
    public void SetRadius2_SetsValueofRadius2_Void()
    {
      Ellipse newEllipse = new Ellipse(3, 4);
      int newLength2 = 6;
      newEllipse.SetRadius2(newLength2);
      Assert.AreEqual(newLength2, newEllipse.GetRadius2());
    }

    [TestMethod]
    public void CalculateEllipseArea_ReturnsEllipseArea_Double()
    {
      Ellipse newEllipse = new Ellipse(2, 3);
      double area = newEllipse.CalculateEllipseArea();
      Assert.AreEqual(18.84955592153876, area);
    }
  }
}