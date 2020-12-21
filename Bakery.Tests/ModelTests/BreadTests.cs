using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBread_Bread()
        {
            Bread bread = new Bread();
            Assert.AreEqual(typeof(Bread), bread.GetType());
        }
        [TestMethod]
        public void GetPrice_ReturnsPriceOfBread_Double()
        {
            Bread bread = new Bread();
            double testPrice = 5;
            bread.Price = 5;
            double price = bread.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void SetPrice_SetsPriceOfBread_Double()
        {
            Bread bread = new Bread();
            double testPrice = 5;
            double price = bread.SetPrice(5);
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void TotalPriceBread_ReturnsDiscountedTotalWhenTriggered_Double()
        {
            Bread bread = new Bread();
            double testTotalPrice = 8;
            double result = bread.TotalPriceBread(2);
            Assert.AreEqual(testTotalPrice, result);
        }
        [TestMethod]
        public void TotalPriceBread_ReturnsDiscountedPricePlusRegularPriceOnOddNumberedOrders_Double()
        {
            Bread bread = new Bread();
            double testTotalPrice = 13;
            double result = bread.TotalPriceBread(3);
            Assert.AreEqual(testTotalPrice, result);
        }
    }
}