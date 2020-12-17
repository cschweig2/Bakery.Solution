using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Bread
    {
        private int _price { get; set; }
        public int OrderNum { get; set; }

        public Bread(int orderNum)
        {
            OrderNum = orderNum;
            _price = 0;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int SetPrice(int price)
        {
            if (price >= 2)
            {
                _price = 1;
            }
            return _price;
        }
        
    }
}
