using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceofPastry_Pastry()
        {
            Pastry pastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), pastry.GetType());
        }
        [TestMethod]
        public void GetPrice_ReturnsPriceOfPastry_Double()
        {
            Pastry pastry = new Pastry();
            double testPrice = 2.00;
            pastry.SetPrice(2.00);
            double result = pastry.GetPrice();
            Assert.AreEqual(testPrice, result);
        }
        [TestMethod]
        public void SetPrice_SetsPriceOfPastry_Double()
        {
            Pastry pastry = new Pastry();
            double testPrice = 1.50;
            double result = pastry.SetPrice(1.50);
            Assert.AreEqual(testPrice, result);
        }
        [TestMethod]
        public void TotalPricePastry_ReturnsDiscountedTotalWhenTriggered_Double()
        {
            Pastry pastry = new Pastry();
            double totalTestPrice = 3.00;
            double result = pastry.TotalPricePastry(2);
            Assert.AreEqual(totalTestPrice, result);
        }
        [TestMethod]
        public void TotalPricePastry_ReturnsDiscountedTotalWhenOrderIsThreeOrMore_Double()
        {
            Pastry pastry = new Pastry();
            double totalTestPrice = 5.00;
            double result = pastry.TotalPricePastry(3);
            Assert.AreEqual(totalTestPrice, result);
        }
    }
}
