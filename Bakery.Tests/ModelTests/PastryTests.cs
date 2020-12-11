using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            double price = pastry.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void SetPrice_SetsPriceOfPastry_Double()
        {
            Pastry pastry = new Pastry();
            double testPrice = 1.50;
            double price = pastry.SetPrice(1.50);
            Assert.AreEqual(testPrice, price);
        }
    }
}
