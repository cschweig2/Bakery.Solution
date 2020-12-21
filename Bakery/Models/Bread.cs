using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public double Price { get; set; }

        public Bread()
        {
            Price = 0;
        }

        public double GetPrice()
        {
            return Price;
        }

        public double SetPrice(double price)
        {
            Price = price;
            return Price;
        }

        public double TotalPriceBread(double orderNum)
        {
            if (orderNum % 2 == 0)
            {
                SetPrice(4);
                double totalPrice = Price * orderNum;
                return totalPrice;
            }
            else if ((orderNum - 1) % 2 == 0)
            {
                SetPrice(4);
                double totalPrice = Price * (orderNum - 1);
                return totalPrice + 5;
            }
            else
            {
                return Price * orderNum;
            }
        }

    }
}
