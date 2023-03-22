using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests
  {
    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 4;
      Rectangle newRectangle = new Rectangle(length1, 2);
      int result = newRectangle.Side1;
      Assert.AreEqual(length1, result);
    }

    [TestMethod]
    public void SetSide1_SetsValueofSide1_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 3);
      int newLength1 = 44;
      newRectangle.Side1 = newLength1;
      Assert.AreEqual(newLength1, newRectangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      int length2 = 3;
      Rectangle newRectangle = new Rectangle(2, length2);
      int result = newRectangle.Side2;
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Void()
    {
      Rectangle newRectangle = new Rectangle(3, 4);
      int newLength2 = 6;
      newRectangle.Side2 = newLength2;
      Assert.AreEqual(newRectangle.Side2, newLength2);
    }

    [TestMethod]
    public void CalculateRectangleArea_ReturnsRectangleArea_Int()
    {
      Rectangle newRectangle = new Rectangle(5, 6);
      int area = newRectangle.CalculateRectangleArea();
      Assert.AreEqual(30, area);
    }
  }
}