using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;

namespace Brello.Tests.Controllers
{
    [TestClass]
    public class BoardControllerTest
    {
        [TestMethod]
        public void BoardControllerEnsureIndexPageExists()
        {
            // Arrange
            BoardController controller = new BoardController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BoardControllerEnsureIndexViewExists()
        {
            // Arrange
            BoardController controller = new BoardController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void BoardControllerEnsureItHasThings()
        {
            // Arrange
            BoardController controller = new BoardController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            string expected_message = "My Boards";
            Assert.AreEqual(expected_message, result.ViewBag.Message);
        }
    }
}
