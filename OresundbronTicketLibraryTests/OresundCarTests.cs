using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundbronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundCarTests
    {
        /// <summary>
        /// Test for korrekt pris uden rabat for OresundCar.
        /// </summary>
        [TestMethod]
        public void Price_ReturnsCorrectPrice()
        {
            // Arrange
            var car = new OresundCar();
            double expectedPrice = 410;

            // Act
            double actualPrice = car.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Prisen for Oresund Car er ikke korrekt.");
        }

        /// <summary>
        /// Test for korrekt pris med Brobizz-rabat for OresundCar.
        /// </summary>
        [TestMethod]
        public void PriceWithBrobizz_ReturnsCorrectDiscountedPrice()
        {
            // Arrange
            var car = new OresundCar();
            double expectedPriceWithBrobizz = 161;

            // Act
            double actualPriceWithBrobizz = car.PriceWithBrobizz();

            // Assert
            Assert.AreEqual(expectedPriceWithBrobizz, actualPriceWithBrobizz, 0.001, "Prisen med Brobizz-rabat for Oresund Car er ikke korrekt.");
        }

        /// <summary>
        /// Test for korrekt køretøjstype for OresundCar.
        /// </summary>
        [TestMethod]
        public void VehicleType_ReturnsCorrectVehicleType()
        {
            // Arrange
            var car = new OresundCar();
            string expectedVehicleType = "Oresund Car";

            // Act
            string actualVehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual(expectedVehicleType, actualVehicleType, "Køretøjstypen for Oresund Car er ikke korrekt.");
        }
    }
}
