using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    public class Drink
    {
        private string _size { get; set; }
        private double _price { get; set; }

        public Drink(string size, double price)
        {
            _size = size;
            _price = price;
        }

        public double GetPrice()
        {
            return _price;
        }

        public string GetSize()
        {
            return _size;
        }
    }
}