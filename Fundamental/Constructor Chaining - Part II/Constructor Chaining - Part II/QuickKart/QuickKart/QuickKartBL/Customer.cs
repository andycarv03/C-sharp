using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public long ContactNumber { get; set; }
        public string ContactAddress { get; set; }

        public static int count;

        static Customer()
        {
            count = 1000;
        }
        public Customer()
        {
            CustomerId = ++count;
            Console.WriteLine("Base class Customer - Constuctor executed");
        }

        public Customer(string customerName, string emailId, long contactNumber, string contactAddress)
        {
            this.CustomerName = customerName;
            this.EmailId = emailId;
            this.ContactNumber = contactNumber;
            this.ContactAddress = contactAddress;
        }
    }
}

