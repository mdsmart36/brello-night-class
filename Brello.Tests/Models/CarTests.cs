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
            Car car = new Car();
            Assert.IsNotNull(car);
        }

        [TestMethod]
        public void CarEnsureMyCarCanHonk()
        {
            Car car = new Car();
            Assert.AreEqual("Honk!", car.Horn());
        }

        [TestMethod]
        public void CarEnsureICanMockMyCarHorn()
        {
            Mock<Car> mock_car = new Mock<Car>();
            mock_car.Setup(x => x.Horn()).Returns("Beep!");
            Assert.AreEqual("Beep!", mock_car.Object.Horn());
        }

        [TestMethod]
        public void CarEnsureICanMockInterface()
        {
            Mock<ICar> mock_car = new Mock<ICar>();
            mock_car.Setup(x => x.Horn()).Returns("Beep!");
            Assert.AreEqual("Beep!", mock_car.Object.Horn());
            mock_car.Verify(x => x.Horn(), Times.Once);
        }

        /* Mock requires methods to be called explicitly ??
        [TestMethod]
        public void CarEnsureReadyEnginesIsCalled()
        {
            Mock<Car> mock_car = new Mock<Car>();
            //mock_car.Setup(x => x.Horn()).Returns("Beep!");
            
            mock_car.Object.Horn();
            //Assert.AreEqual("Beep!", mock_car.Object.Horn());
            mock_car.Verify(x => x.ReadyEngines(), Times.Once);
        }
        */
    }
}
