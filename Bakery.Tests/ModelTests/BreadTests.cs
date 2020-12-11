using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Bakery.Tests
{
    [TestClass]
    public class BakeryTests
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
            int price = bread.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void SetPrice_SetsPriceOfBread_Int()
        {
            Bread bread = new Bread();
            int testPrice = 2;
            int price = bread.SetPrice(2);
            Assert.AreEqual(testPrice, price);
        }
    }
}