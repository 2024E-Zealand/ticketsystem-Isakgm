using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class WeekendDiscountTests
    {
        [TestMethod]
        public void FinalPrice_ApplyWeekendAndBrobizzDiscount_WhenSaturdayAndBrobizz()
        {
            // Arrange
            var discount = new WeekendDiscount();
            DateTime saturday = new DateTime(2023, 10, 7); // En lørdag
            double weekendPrice = 240 - (240 * 0.20); // Først weekendrabat
            double expectedPrice = weekendPrice - (weekendPrice * 0.05); // Så Brobizz-rabat

            // Act
            double actualPrice = discount.FinalPrice(saturday, true);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Rabat for lørdag og Brobizz blev ikke korrekt anvendt.");
        }

        [TestMethod]
        public void FinalPrice_ApplyWeekendDiscount_WhenSaturdayWithoutBrobizz()
        {
            // Arrange
            var discount = new WeekendDiscount();
            DateTime saturday = new DateTime(2023, 10, 7); // En lørdag
            double expectedPrice = 240 - (240 * 0.20); // Kun weekendrabat

            // Act
            double actualPrice = discount.FinalPrice(saturday, false);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Rabat for lørdag uden Brobizz blev ikke korrekt anvendt.");
        }

        [TestMethod]
        public void FinalPrice_ApplyBrobizzDiscount_WhenWeekdayAndBrobizz()
        {
            // Arrange
            var discount = new WeekendDiscount();
            DateTime wednesday = new DateTime(2023, 10, 4); // En onsdag
            double expectedPrice = 240 - (240 * 0.05); // Kun Brobizz-rabat

            // Act
            double actualPrice = discount.FinalPrice(wednesday, true);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Brobizz-rabat for hverdag blev ikke korrekt anvendt.");
        }

        [TestMethod]
        public void FinalPrice_NoDiscount_WhenWeekdayWithoutBrobizz()
        {
            // Arrange
            var discount = new WeekendDiscount();
            DateTime wednesday = new DateTime(2023, 10, 4); // En onsdag
            double expectedPrice = 240; // Ingen rabat

            // Act
            double actualPrice = discount.FinalPrice(wednesday, false);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice, 0.001, "Prisen uden rabat blev ikke korrekt anvendt.");
        }
    }
}