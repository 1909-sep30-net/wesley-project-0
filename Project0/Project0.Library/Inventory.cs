using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Inventory
    {
        //return list of inventory
        public List<Merchandise> inventory { get; set;}

        public Inventory(List<Merchandise> i)
        {
            inventory = i;
        }

        public void inventoryAmount(List<Merchandise> stock)
        {
            // return what is in stock
            foreach (Merchandise item in stock)
                Console.WriteLine("The items in stock are: " + item);
        }
    }
}
