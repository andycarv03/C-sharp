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
        public string GetCustomerInformation()
        {
            string details = string.Empty;
            details += string.Format("CustomerId = {0}\nCustomerName = {1}\nEmailId = {2}\n" +
                "ContactNumber = {3}\nContactAddress = {4}\n",
                this.CustomerId, this.CustomerName, this.EmailId,
                this.ContactNumber, this.ContactAddress);
            return details;
        }
    }
}

