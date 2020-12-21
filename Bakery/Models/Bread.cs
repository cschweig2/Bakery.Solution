using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        public static int Price { get; set; }

        public Bread()
        {
            Price = 0;
        }

        public int GetPrice()
        {
            return Price;
        }

        public int SetPrice(int price)
        {
            Price = price;
            return Price;
        }

        public static int TotalPriceBread(int orderNum)
        {
            if (orderNum % 2 == 0)
            {
                Price = 4;
                int totalPrice = Price * orderNum;
                return totalPrice;
            }
            else if ((orderNum - 1) % 2 == 0)
            {
                Price = 4;
                int totalPrice = 4 * (orderNum - 1);
                return totalPrice + 5;
            }
            else
            {
                return Price * orderNum;
            }
        }

    }
}
