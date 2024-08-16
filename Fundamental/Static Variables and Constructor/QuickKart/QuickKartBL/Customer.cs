using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        /* Auto-implemented properties. NO private variables and NO logic within the accessor methods.
         * Compiler will set the value to zero/null if no value passed to the object.
         */
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        static private int counter;                     //We can also intialise static variable in a signle-line

        static Customer()                               //static constructor executed one time before the instantiation of the first object of the class
        {
            //Initialise static variables
            counter = 1000;
        }

        public Customer()
        {
            //counter = 1000;                           //Initialising static variable within a class contructor will make it a variable local to the instantiated object
            counter = counter + 1;
            CustomerId = counter;

        }
    }
}
