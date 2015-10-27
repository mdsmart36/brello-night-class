using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;

namespace Brello.Tests.Models
{
    [TestClass]
    public class VoteTests
    {
        [TestMethod]
        public void EnsureICanCreateVoteClassInstance()
        {
            Vote vote = new Vote();
            Assert.IsNotNull(vote);
        }
    }
}
