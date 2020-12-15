using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Drink
    {
        private string _size { get; set; }
        private int _price = 2;

        public Drink(string size, int price)
        {
            _size = size;
            _price = price;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}