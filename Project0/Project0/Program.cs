using Project0.Library;
using System;

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

        static void Main(string[] args)
        {
            string firstName, lastName;
            Address address;

            Console.WriteLine("Enter First Name of Customer: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name of Customer: ");
            lastName = Console.ReadLine();

            Customer customer = new Customer(firstName, lastName, address);

        }
    }
}
