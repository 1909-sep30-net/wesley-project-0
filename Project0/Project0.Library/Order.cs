using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Order
    {
        //private list<string> orders = new list<string>();
        //public void ordernumber()
        //{

        //}
        //public void add(string item)
        //{
        //    orders.add(item);
        //}
        //public void remove(string item)
        //{
        //    orders.remove(item);
        //}

        //Information about the order
        public Store Store {get; set;}
        public Customer Customer { get; set;}
        public double OrderTime { get; set; }
        public List<Merchandise> m { get; set; }


        public Order(Customer cust, Store sto, double time, List<Merchandise> n)
        {
            Customer = cust;
            Store = sto;
            OrderTime = time;
        }

        //check order address and validity of order
        public Address OrderStoreAddress()
        {
            Console.WriteLine("Store's Address is: " + Store.GetStoreAddress());
            return Store.GetStoreAddress();
        }

        public bool IsOrderValid(Order order)
        {
            if (order.Customer != null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
