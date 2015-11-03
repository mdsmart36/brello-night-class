using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;
using System.Collections.Generic;

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
            Board board = new Board { Title = "My Board" };


            BrelloList brello_list = new BrelloList { Title = "My List" };
            board.Lists.Add(brello_list);

            ApplicationUser a_user = new ApplicationUser();
            board.Followers.Add(a_user);
            

            Assert.AreEqual("My Board", board.Title);
            Assert.AreEqual(1, board.Lists.Count);
            Assert.AreEqual(1, board.Followers.Count);
        }
    }
}
