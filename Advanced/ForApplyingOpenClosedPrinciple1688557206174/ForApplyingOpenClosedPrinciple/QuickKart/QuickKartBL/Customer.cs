using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }

        public Customer(string customerId, string customerName, string contactNumber,
            string emailId, string address)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.ContactNumber = contactNumber;
            this.EmailId = emailId;
            this.Address = address;
        }

        public virtual string GetCustomerDetails()
        {
            string details = null;

            details = string.Format("{0, -20}: {1}\n", "Customer Id", this.CustomerId);
            details += string.Format("{0, -20}: {1}\n", "Customer Name", this.CustomerName);
            details += string.Format("{0, -20}: {1}\n", "ContactNumber", this.ContactNumber);
            details += string.Format("{0, -20}: {1}\n", "Email Id", this.EmailId);
            details += string.Format("{0, -20}: {1}\n", "Address", this.Address);

            return details;
        }
        public string UpdateContactDetails(string contactNumber, string emailId, string address)
        {
            if (contactNumber != null)
            {
                this.ContactNumber = contactNumber;
            }
            if (emailId != null)
            {
                this.EmailId = emailId;
            }
            if (address != null)
            {
                this.Address = address;
            }
            return "\nContact Details UPDATED successfully!";
        }
    }
}
