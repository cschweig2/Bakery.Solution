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
        public void GetPrice_ReturnsPriceOfPastry_Int()
        {
            Pastry pastry = new Pastry();
            int testPrice = 2;
            int price = pastry.GetPrice();
            Assert.AreEqual(testPrice, price);
        }

    }
}
