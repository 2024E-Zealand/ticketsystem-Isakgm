using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod]
        public void LicensePlate_SetAndGet_ReturnsCorrectValue()
        {
            // Arrange
            var vehicle = new MC();
            string expectedLicensePlate = "AB12345";

            // Act
            vehicle.LicensePlate = expectedLicensePlate;
            string actualLicensePlate = vehicle.LicensePlate;

            // Assert
            Assert.AreEqual(expectedLicensePlate, actualLicensePlate);
        }

        [TestMethod]
        public void Date_SetAndGet_ReturnsCorrectValue()
        {
            // Arrange
            var vehicle = new MC();
            DateTime expectedDate = new DateTime(2023, 10, 1);

            // Act
            vehicle.Date = expectedDate;
            DateTime actualDate = vehicle.Date;

            // Assert
            Assert.AreEqual(expectedDate, actualDate);
        }

        [TestMethod]
        public void Price_ReturnsCorrectValue()
        {
            // Arrange
            var vehicle = new MC();
            double expectedPrice = 125;

            // Act
            double actualPrice = vehicle.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void VehicleType_ReturnsCorrectType()
        {
            // Arrange
            var vehicle = new MC();
            string expectedType = "MC";

            // Act
            string actualType = vehicle.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }
        
        
    }
}