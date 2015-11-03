using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Models;
using Moq;

namespace Brello.Tests.Models
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarEnsureICanCreateInstance()
        {
            Car mycar = new Car();
            Assert.IsNotNull(mycar);
        }

        [TestMethod]
        public void CarEnsureMyCarCanHonk()
        {
            Car mycar = new Car();
            Assert.AreEqual("HONK!", mycar.Horn());
        }

        [TestMethod]
        public void CarEnsureICanMockMyCarHorn()
        {
            Mock<Car> mock_car = new Mock<Car>();
            mock_car.Setup(x => x.Horn()).Returns("BEEP!");
            Assert.AreEqual("BEEP!", mock_car.Object.Horn());
        }
        /*
        [TestMethod]
        public void CarEnsureICanMockInterface()
        {
            // Honk() was called atleast once
            Mock<ICar> mock_car = new Mock<ICar>();
            // This is invalid: var myvar = new ICar();
            //Assert.AreEqual("BEEP!", mock_car.Object.Honk());
            mock_car.Verify(x => x.Honk(), Times.Once());
        }
        */

        /*
        //Moq Requires methods to be called explicitly after setup.
        
        [TestMethod]
        public void CarEnsureReadyEngineIsCalled()
        {
            Mock<Car> mock_car = new Mock<Car>();
            
            mock_car.Setup(x => x.ReadyEngines());
            mock_car.Object.Horn();
            //mock_car.Setup(x => x.Horn()).Returns("BEEP!");
            //Assert.AreEqual("BEEP!", mock_car.Object.Horn());
            mock_car.Verify(x => x.ReadyEngines(), Times.Once());
        }
        */
        
    }
}
