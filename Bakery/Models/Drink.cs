using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Drink
    {
        private string _size { get; set; }
        private int _price { get; set; }

        public Drink(string size, int price)
        {
            _size = size;
            _price = price;
        }
    }
}