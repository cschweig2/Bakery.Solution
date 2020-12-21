using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    {
        public double Price { get; set; }

        public Pastry()
        {
            Price = 0;
        }

        public double GetPrice()
        {
            return Price;
        }

        public double SetPrice(double price)
        {
            if (price >= 1.50)
            {
                Price = price;
            }
            return Price;
        }

        public double TotalPricePastry(int orderNum)
        {
            if (orderNum % 2 == 0)
            {
                SetPrice(1.50);
                double totalPastry = Price * System.Convert.ToDouble(orderNum);
                return totalPastry;
            }
            else if ((orderNum - 1) % 2 == 0)
            {
                SetPrice(1.50);
                double totalPastry = Price * System.Convert.ToDouble(orderNum - 1);
                return totalPastry += 2;
            }
            else
            {
                return Price * orderNum;
            }
        }
        
    }
}