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
                SetPrice(2.50);
                double totalPastry = Price * System.Convert.ToDouble(orderNum);
                return totalPastry;
            }
            else
            {
                return Price * orderNum;
            }
        }
    }
}

// public static void TotalPricePastry(int orderNum)
//         {
//             Pastry pastry = new Pastry(orderNum);
//             if (orderNum % 2 == 0)
//             {
//                 pastry.SetPrice(1.50);
//                 double pastryPrice = pastry.GetPrice();
//                 double totalPastry = pastryPrice * System.Convert.ToDouble(orderNum);
//                 orderTotal += totalPastry;
//                 Console.WriteLine("Your subtotal is $" + orderTotal + ".");
//             }
//             else if ((orderNum - 1) % 2 == 0)
//             {
//                 pastry.SetPrice(1.50);
//                 double pastryPrice = pastry.GetPrice();
//                 double totalPastry = pastryPrice * (System.Convert.ToDouble(orderNum) - 1);
//                 orderTotal += totalPastry + 2;
//                 Console.WriteLine("Your subtotal is $" + orderTotal + ".");
//             }
//             else
//             {
//                 pastry.SetPrice(2);
//                 double pastryPrice = pastry.GetPrice();
//                 double totalPastry = pastryPrice * System.Convert.ToDouble(orderNum);
//                 orderTotal += totalPastry;
//                 Console.WriteLine("Your subtotal is $" + orderTotal + ".");
//             }
//         }