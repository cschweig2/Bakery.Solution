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
        public void GetPrice_ReturnsPriceOfBread_Int()
        {
            Bread bread = new Bread();
            int testPrice = 5;
            bread.Price = 5;
            int price = bread.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void SetPrice_SetsPriceOfBread_Int()
        {
            Bread bread = new Bread();
            int testPrice = 5;
            int price = bread.SetPrice(5);
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void TotalPriceBread_ReturnsDiscountedTotalWhenTriggered_Int()
        {
            Bread bread = new Bread();
            int testTotalPrice = 8;
            int result = bread.TotalPriceBread(2);
            Assert.AreEqual(testTotalPrice, result);
        }
        [TestMethod]
        public void TotalPriceBread_ReturnsDiscountedPricePlusRegularPriceOnOddNumberedOrders_Int()
        {
            Bread bread = new Bread();
            int testTotalPrice = 13;
            int result = bread.TotalPriceBread(3);
            Assert.AreEqual(testTotalPrice, result);
        }
    }
}