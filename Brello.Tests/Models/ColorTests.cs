using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;

namespace Brello.Tests.Models
{
    [TestClass]
    public class ColorTests
    {
        [TestMethod]
        public void ColorEnsureICanCreateInstance()
        {
            Color c = new Color();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void ColorEnsurePropertiesWork()
        {
            // Object Initializer syntax
            Color c = new Color {Name = "Blue", Value = "#0000ff"};
            // Otherwise you'd have to
            /*
            Color c = new Color();
            c.Name = "Blue";
            c.Value = "#0000ff";
            */
            Assert.AreEqual("Blue", c.Name);
            Assert.AreEqual("#0000ff", c.Value);
        }

        [TestMethod]
        public void ColorEnsureColorsAreEqual()
        {
            Color color1 = new Color { Name = "Blue", Value = "#0000ff" };
            Color color2 = new Color { Name = "Blue", Value = "#0000ff" };
            Assert.AreEqual(0, color1.CompareTo(color2));
            Assert.IsTrue(color1 == color2);
        }

        [TestMethod]
        public void ColorEnsureColorsAreNotEqual()
        {
            Color color1 = new Color { Name = "Blue", Value = "#0000ff" };
            Color color2 = new Color { Name = "Red", Value = "#ff0000" };
            Assert.IsTrue(0 != color1.CompareTo(color2));
            Assert.IsTrue(color1 != color2);
        }

        [TestMethod]
        public void ColorEnsureGreaterThanComparison()
        {
            Color color1 = new Color { Name = "Blue", Value = "#0000ff" };
            Color color2 = new Color { Name = "Black", Value = "#000000" };
            Assert.AreEqual(1, color1.CompareTo(color2));
            Assert.IsTrue(color1 > color2);
        }

        [TestMethod]
        public void ColorEnsureLessThanComparison()
        {
            Color color1 = new Color { Name = "Blue", Value = "#0000ff" };
            Color color2 = new Color { Name = "Red", Value = "#ff0000" };
            Assert.AreEqual(-1, color1.CompareTo(color2));
            Assert.IsTrue(color1 < color2);
        }
    }
}
