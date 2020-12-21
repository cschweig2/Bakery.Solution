using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Drink
    {
        public string Size { get; set; }
        public double Price { get; set; }

        public Drink(string size, double price)
        {
            Size = size;
            Price = price;
        }

        public double GetPrice()
        {
            return Price;
        }

        public string GetSize()
        {
            return Size;
        }

        public double TotalPriceCoffee(int orderNum)
        {
            return Price * orderNum;
        }
    }
}



        // public static void TotalPriceCoffee(string size)
        // {
        //     if (size == "Small")
        //     {
        //         Drink coffeeSmall = new Drink("small", 1);
        //         double price = coffeeSmall.GetPrice();
        //         orderTotal += price;
        //         Console.WriteLine("Your subtotal is $" + orderTotal + ".");
        //     }
        //     else if (size == "Medium")
        //     {
        //         Drink coffeeMed = new Drink("medium", 2);
        //         double price = coffeeMed.GetPrice();
        //         orderTotal += price;
        //         Console.WriteLine("Your subtotal is $" + orderTotal + ".");
        //     }
        //     else if (size == "Large")
        //     {
        //         Drink coffeeLge = new Drink("Large", 3);
        //         double price = coffeeLge.GetPrice();
        //         orderTotal += price;
        //         Console.WriteLine("Your subtotal is $" + orderTotal + ".");
        //     }
        // }
