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
    public class CarTests
    {
        [TestMethod]
        public void LicensePlate_SetAndGet_ReturnsCorrectValue()
        {
            // Arrange
            var vehicle = new Car();
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
            var vehicle = new Car();
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
            var vehicle = new Car();
            double expectedPrice = 240;

            // Act
            double actualPrice = vehicle.Price();

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void VehicleType_ReturnsCorrectType()
        {
            // Arrange
            var vehicle = new Car();
            string expectedType = "Car";  

            // Act
            string actualType = vehicle.VehicleType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlate_ThrowsException_WhenMoreThanSevenCharacters()
        {
            // Arrange
            var vehicle = new Car();
            string invalidLicensePlate = "AB123456"; // 8 tegn

            // Act
            vehicle.LicensePlate = invalidLicensePlate;

            // Assert
            // ExpectedException håndterer assert
        }

        [TestMethod]
        public void LicensePlate_ThrowsCorrectMessage_WhenMoreThanSevenCharacters()
        {
            // Arrange
            var vehicle = new Car();
            string invalidLicensePlate = "ABCDEFGH"; // 8 tegn

            try
            {
                // Act
                vehicle.LicensePlate = invalidLicensePlate;
                Assert.Fail("No exception was thrown."); // Hvis ingen undtagelse, fejler testen
            }
            catch (ArgumentException ex)
            {
                // Assert
                Assert.AreEqual("Nummerpladen må ikke være længere end 7 tegn.", ex.Message);
            }


        }

        [TestMethod]
        public void PriceWithBrobizz_ReturnsCorrectDiscountedPrice()
        {
            // Arrange
            var vehicle = new Car(); 
            double expectedPriceWithBrobizz = 240 - (240 * 0.05); // Beregner den forventede pris med 5% rabat

            // Act
            double actualPriceWithBrobizz = vehicle.PriceWithBrobizz();

            // Assert
            Assert.AreEqual(expectedPriceWithBrobizz, actualPriceWithBrobizz, 0.001, "Prisen med Brobizz-rabat er ikke korrekt.");
        }
    }
}