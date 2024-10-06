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
    public class OresundMCTests
    {
        [TestMethod]
        public void Price_ReturnsCorrectPrice()
        {
            // Arrange
            var mc = new OresundMC();
            double expectedPrice = 210;

            // Act
            double actualPrice = mc.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Prisen for Oresund MC er ikke korrekt.");
        }

        [TestMethod]
        public void PriceWithBrobizz_ReturnsCorrectDiscountedPrice()
        {
            // Arrange
            var mc = new OresundMC();
            double expectedPriceWithBrobizz = 73;

            // Act
            double actualPriceWithBrobizz = mc.PriceWithBrobizz();

            // Assert
            Assert.AreEqual(expectedPriceWithBrobizz, actualPriceWithBrobizz, 0.001, "Prisen med Brobizz-rabat for Oresund MC er ikke korrekt.");
        }

        [TestMethod]
        public void VehicleType_ReturnsCorrectVehicleType()
        {
            // Arrange
            var mc = new OresundMC();
            string expectedVehicleType = "Oresund MC";

            // Act
            string actualVehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual(expectedVehicleType, actualVehicleType, "Køretøjstypen for Oresund MC er ikke korrekt.");
        }
    }
}