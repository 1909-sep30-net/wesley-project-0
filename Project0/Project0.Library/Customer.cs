using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Customer
    {
        public Customer(string firstName, string lastName, Address address)
        {
            SetName(firstName, lastName);
            SetAddress(address);
        }

        private string firstName;
        private string lastName;
        private Address address;

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public void SetName(string firstName, string lastName)
        {
            if (firstName == null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }
            else if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Address Getaddress()
        {
            return address;
        }

        public void SetAddress(Address customerAddress)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            this.address = customerAddress;
        }
    }
}
