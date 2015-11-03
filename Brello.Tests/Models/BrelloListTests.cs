using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;
using System.Collections.Generic;

namespace Brello.Tests.Models
{
    [TestClass]
    public class BrelloListTests
    {
        [TestMethod]
        public void BrelloListEnsureICanCreateInstance()
        {
            BrelloList brello_list = new BrelloList();
            Assert.IsNotNull(brello_list);
        }

        [TestMethod]
        public void BrelloListEnsurePropertiesWork()
        {
            Card card1 = new Card { Title = "My Card" };
            List<Card> list_of_cards = new List<Card>();
            list_of_cards.Add(card1);
            BrelloList list = new BrelloList { Title = "My List",
                                               BrelloListId = 1,
                                               CreatedAt = DateTime.Parse("2015-01-02"),
                                               Cards = list_of_cards };
            Assert.AreEqual("My List", list.Title);
            Assert.AreEqual(1, list.Cards.Count);
        }
    }
}
