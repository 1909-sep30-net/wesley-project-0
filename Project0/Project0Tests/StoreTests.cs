using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Project0.Library;

namespace Project0Tests
{
    public class StoreTests
    {
        
        // we need the connection string to connect to the database..
        // but it should not be uploaded to public github




        /*[Theory]
        [InlineData("123 Sesame Street", "Sesame", "SE", "12345")]
        [InlineData()]
        [InlineData()]
        public void DoesAddressWork(string a, string b, string c, string d)
        {
            //arrange
            Address k = new Address(a, b, c, d);

            //act


            //assert
        }*/

        [Theory]
        [InlineData("123 sesame st", "dallas", "TX", "1954")]
        [InlineData("aoqiwme", "Var", "VA", "9520")]
        [InlineData("cxedr", "Car", "CA", "8520025")]
        public void DoesCheckAddressTrueWork(string a, string b, string c, string d)
        {
            //arrange
            Address k;

            //act
            k = new Address(a, b, c, d);

            //assert
            Assert.True(k.CheckValidAddress());
        }

        [Theory]
        [InlineData(null, "dallas", "TX", "1954")]
        [InlineData("aoqiwme", null, "VA", "9520")]
        [InlineData("cxedr", "Car", null, "8520025")]
        [InlineData("zxcv", "qwer", "asdf", null)]
        public void DoesCheckAddressFalseWork(string a, string b, string c, string d)
        {
            //arrange
            Address k;

            //act
            k = new Address(a, b, c, d);

            //assert
            Assert.False(k.CheckValidAddress());
        }

        [Theory]
        [InlineData("123 sesame st", "dallas")]
        [InlineData("aoqiwme", "Var")]
        [InlineData("cxedr", "Car")]
        public void DoesCheckCustomerTrueWork(string a, string b)
        {
            //arrange
            Customer k;

            //act
            k = new Customer(a, b);

            //assert
            Assert.True(k.CheckValidCustomer());
        }

        [Theory]
        [InlineData(null, "abcd")]
        [InlineData("zxcv", null)]
        public void DoesCheckCustomerFalseWork(string a, string b)
        {
            //arrange
            Customer k;

            //act
            k = new Customer(a, b);

            //assert
            Assert.False(k.CheckValidCustomer());
        }

        /*[Theory]
        [InlineData(, "abcd")]
        [InlineData("zxcv", null)]
        public void DoesCheckOrderTrueWork(string a, string b)
        {
            //arrange
            Customer k;

            //act
            k = new Customer(a, b);

            //assert
            Assert.True(k.IsOrderValid());
        }

        [Theory]
        [InlineData(, "abcd")]
        [InlineData(, null)]
        public void DoesCheckOrderFalseWork(Customer a, string b)
        {
            //arrange
            Order k;

            //act
            k = new Order(a, b);

            //assert
            Assert.False(k.IsOrderValid());
        }*/
    }
}
