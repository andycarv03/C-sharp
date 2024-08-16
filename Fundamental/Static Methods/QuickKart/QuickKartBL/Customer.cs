using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        //Auto-implemented properties.
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        //static variable declaration
        private static int counter;

        //static variable initialised in static constructor
        static Customer()
        {
            counter = 1000;
        }
        
        //parameterless constructor
        public Customer()
        {
            CustomerId = ++counter;
        }

        public static int GetTotalNumberOfCustomer()
        {
            int TotalCustomer = counter - 1000;
            return TotalCustomer;
        }
    }
}
