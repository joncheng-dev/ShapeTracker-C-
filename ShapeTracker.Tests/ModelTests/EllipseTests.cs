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
  }
}