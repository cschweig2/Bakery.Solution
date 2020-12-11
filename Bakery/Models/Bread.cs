using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        private int _price = 5;

        public int GetPrice()
        {
            return _price;
        }

        public int SetPrice(int price)
        {
            if (price >= 2)
            {
                _price = price;
            }
            return _price;
        }
    }
}
