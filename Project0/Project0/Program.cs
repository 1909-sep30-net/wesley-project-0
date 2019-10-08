using Project0.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project0
{
    class Program
    {
        //shortcuts for VS
        //CTRL + K, CTRL + C for commenting lines
        //CTRL + K, CTRL + U for uncommenting lines
        //CTRL + K, CTRL + D for formatting documents
        //CTRL + Shift + B builds the solution
        //CTRL + F5 runs without debugging
        //<snippet name><TAB><TAB> for snippets like "prop" for property
        //  <TAB> to navigate between the fields of that snippet

        //shortcuts for VS Code
        // CTRL + / for comment and uncomment
        // Alt+Shift+F for formatting document

        //----------------------------------------------------------------

        // casting / type conversion
        //among numeric types, conversions that could lose any data
        //  must be explicit with casting operator ()
        //otherwise they can be implicit
        //with these numeric conversions, the actual bytes are being changed

        // int five = 5;
        //double otherFive = five;
        //int nextFive = (int)otherFive;

        // conversions when type heirarchies are concerned
        // var list = new List<int>();
        //object o = list; //implicit upcasting
        //List<int> listAgain = (List<int>)o //explicit downcasting
        //      "could fail" - InvalidCastException if that object is not already really a List<int>
        //IList<int> ilist = list;
        Customer customer;
        Store k;
        Order a;
        static void Main(string[] args)
        {
            Program store = new Program();
            store.Menu(); 
        }

        public void Menu()
        {
            string quit = null;
            int menu = 0;
            Console.WriteLine("Welcome to Stores Store");
            Console.WriteLine("What you want");
            Console.WriteLine("1. Place order");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Add Store");
            Console.WriteLine("4. Exit");
            Console.WriteLine("-----------------------");

            do
            {
                Console.WriteLine("Enter a number between 1 and 4 or q to quit");
                quit = Console.ReadLine();
                if(quit != "q")
                {
                    menu = Int32.Parse(quit);
                }
                if (menu < 1 || menu > 4)
                {
                    Console.WriteLine("input must be between 1 and 4");
                }
            } while (menu < 1 || menu > 4 || quit != "q");

            switch (menu)
            {
                //place order
                case 1:
                    PlaceOrder();
                    break;

                //customer info
                case 2:
                    AddCustomer();
                    break;

                //Store info and inventory
                case 3:
                    StoreInfo();
                    break;
                default:
                    Console.WriteLine("Please come again soon.");
                    break;
            }
        }

        public void PlaceOrder()
        {
            int merch = 0;
            string quit = null;
            double time = 0;
            string box = "box", hat = "hat", shoe = "shoe";
            double bp = 3.20, hp = 5.90, sp = 1.50;
            Console.WriteLine("The products we have are: ");
            Console.WriteLine("1. Box at $3.20");
            Console.WriteLine("2. Hat at $5.90");
            Console.WriteLine("3. Shoe at $1.50");
            Merchandise b = new Merchandise(box, bp);
            Merchandise h = new Merchandise(hat, hp);
            Merchandise s = new Merchandise(shoe, sp);
            List<Merchandise> merchList = new List<Merchandise>();

            do
            {
                Console.WriteLine("Enter a number between 1 and 3 or q to quit");
                if(quit != "q")
                    merch = Int32.Parse(Console.ReadLine());
                if (merch < 1 || merch > 3)
                {
                    Console.WriteLine("input not between 1 and 3");
                }
            } while (merch < 1 || merch > 3 || quit != "q");

            switch (merch)
            {
                case 1:
                    merchList.Add(b);
                    break;
                case 2:
                    merchList.Add(h);
                    break;
                case 3:
                    merchList.Add(s);
                    time = Convert.ToDouble(Stopwatch.GetTimestamp());
                    break;
                default:
                    Console.WriteLine("no order placed");
                    break;
            }

            a = new Order(customer, k, time, merchList);
            Console.Clear();
            Menu();
        }

        public void AddCustomer()
        {
            string FirstName, LastName;//, CustStreet, CustCity, CustState, CustZip;

            Console.WriteLine("Enter First Name of Customer: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Customer: ");
            LastName = Console.ReadLine();
            /*Console.WriteLine("Enter Street of Customer Address");
            CustStreet = Console.ReadLine();
            Console.WriteLine("Enter City of Customer Address");
            CustCity = Console.ReadLine();
            Console.WriteLine("Enter State of Customer Address");
            CustState = Console.ReadLine();
            Console.WriteLine("Enter Zip of Customer Address");
            CustZip = Console.ReadLine();*/

           /* Address CustAddress = new Address(CustStreet, CustCity, CustState, CustZip);*/
            /*Customer customer = new Customer(FirstName, LastName, CustAddress);*/
            customer = new Customer(FirstName, LastName);

            Console.Clear();
            Menu();
        }

        public void StoreInfo()
        {

            string name = null;
            int num = 0;

            Console.WriteLine("What is the Store name?");
            name = Console.ReadLine();
            Console.WriteLine("What is the Store number?");
            num = Int32.Parse(Console.ReadLine());

            k = new Store(name, num);
            /*string StoreStreet, StoreCity, StoreState, StoreZip;
            Merchandise m;
            List<Merchandise> n = new List<Merchandise>();
            string merchName;
            double merchPrice;
            string q = null;

            Console.WriteLine("Enter Street of Store Address");
            StoreStreet = Console.ReadLine();
            Console.WriteLine("Enter City of Store Address");
            StoreCity = Console.ReadLine();
            Console.WriteLine("Enter State of Store Address");
            StoreState = Console.ReadLine();
            Console.WriteLine("Enter Zip of Store Address");
            StoreZip = Console.ReadLine();

            while (q != "q")
            {
                Console.WriteLine("Enter Product Name");
                merchName = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                merchPrice = Convert.ToDouble(Console.ReadLine());
                m = new Merchandise(merchName, merchPrice);
                n.Add(m);
                Console.WriteLine("Type q to quit");
                q = Console.ReadLine();
            }
            Address StoreAddress = new Address(StoreStreet, StoreCity, StoreState, StoreZip);
            Inventory c = new Inventory(n);
            Store store = new Store(StoreAddress, c);*/
        }
    }
}
