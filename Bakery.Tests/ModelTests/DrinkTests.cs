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
            Drink coffee = new Drink();
            Assert.AreEqual(typeof(Drink), coffee.GetType());
        }
    }
}