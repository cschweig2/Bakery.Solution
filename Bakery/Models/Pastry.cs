using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Pastry
    {
        private double _price { get; set; }

        public double GetPrice()
        {
            return _price;
        }

        public double SetPrice(double price)
        {
            if (price >= 1.50)
            {
                _price = price;
            }
            return _price;
        }
    }
}