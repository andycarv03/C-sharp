using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class EliteCustomer : Customer
    {
        public int CouponsOwned { get; set; }
        public EliteCustomer()
        {
            Console.WriteLine("Derived class EliteCustomer - Constructor executed");
        }
        public EliteCustomer(string customerName, string emailId, long contactNumber, string contactAddress, int couponsOwned)
        {
            CouponsOwned = couponsOwned;
            Console.WriteLine("Derived class EliteCustomer - Parameterized Constructor executed");
        }
    }
}
