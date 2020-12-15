using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class DrinkTests
    {
        [TestMethod]
        public void DrinkConstructor_CreatesInstanceOfDrink_Drink()
        {
            Drink coffee = new Drink("small", 2);
            Assert.AreEqual(typeof(Drink), coffee.GetType());
        }
        [TestMethod]
        public void GetPrice_GetsPriceOfCoffee_Int()
        {
            Drink coffee = new Drink("small", 2);
            int testPrice = 2;
            int price = coffee.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
    }
}