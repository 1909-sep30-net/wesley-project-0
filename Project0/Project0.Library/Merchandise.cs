using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Merchandise
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Merchandise(string n, double p)
        {
            Name = n;
            Price = p;
        }
    }
}
