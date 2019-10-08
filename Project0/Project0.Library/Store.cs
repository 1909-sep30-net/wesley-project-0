using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Store
    {
        //colorado, texas, georgia, arizona, florida

        public Inventory Inventory { get; set; }

        public Address Address { get; set; }

        public string Name { get; set; }
        public int StoreNum { get; set; }

        public Store(Address a, Inventory i)
        {
            Inventory = i;
            Address = a;
        }

        public Store(string na, int num)
        {
            Name = na;
            StoreNum = num;
        }

        public Address GetStoreAddress()
        {
            return Address;
        }
    }
}
