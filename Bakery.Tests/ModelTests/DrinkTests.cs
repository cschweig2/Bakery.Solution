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
        public void GetPrice_GetsPriceOfCoffee_Double()
        {
            Drink coffee = new Drink("small", 2);
            double testPrice = 2;
            double price = coffee.GetPrice();
            Assert.AreEqual(testPrice, price);
        }
        [TestMethod]
        public void GetSize_GetsSizeOfCoffee_String()
        {
            Drink coffee = new Drink("small", 2);
            string testSize = "small";
            string size = coffee.GetSize();
            Assert.AreEqual(testSize, size);
        }
        [TestMethod]
        public void TotalPriceCofee_ReturnsTotalPriceOfCoffeeOrder_Int()
        {
            Drink coffeeSmall = new Drink("Small", 1);
            double testTotalPrice = 3;
            double result = coffeeSmall.TotalPriceCoffee(3);
            Assert.AreEqual(testTotalPrice, result);
        }
    }
}