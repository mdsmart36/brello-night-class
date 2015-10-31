using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;

namespace Brello.Tests.Models
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void BoardEnsureICanCreateInstance()
        {
            Board board = new Board();
            Assert.IsNotNull(board);
        }

        [TestMethod]
        public void BoardEnsurePropertiesWork()
        {
            //Color color = new Color { Name = "Blue", Value = "#0000ff" };
            // Object Initializer syntax
            Board board = new Board();
            Assert.AreEqual("My Board", board.Title);
            Assert.AreEqual(0, board.Lists.Count);
            Assert.AreEqual(0, board.Followers.Count);
        }
    }
}
