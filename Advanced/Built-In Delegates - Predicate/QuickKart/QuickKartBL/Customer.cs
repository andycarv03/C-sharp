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
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public AlertDelegate AlertPreferences { get; set; }

        static int counter;
        static Customer()
        {
            counter = 1000;
        }

        public Customer()
        {
            CustomerId = ++counter;
        }
        public Customer(string customerName, string address, string emailId, 
            string phoneNumber, AlertDelegate alertPreferences):base()
        {
            this.CustomerName = customerName;
            this.Address = address;
            this.EmailId = emailId;
            this.PhoneNumber = phoneNumber;
            this.AlertPreferences = alertPreferences;
        }
    }
}
