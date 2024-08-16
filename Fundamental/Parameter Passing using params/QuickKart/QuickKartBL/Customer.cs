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
        public string[] DeliveryAddress { get; set; }               //to store n number of addresses

        public Customer(int customerId, string customerName, string emailId, long contactNumber, string contactAddress)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.EmailId = emailId;
            this.ContactNumber = contactNumber;
            this.ContactAddress = contactAddress;
        }

        public string AddDeliveryAddress(params string[] deliveryAddress)
        {
            this.DeliveryAddress = deliveryAddress;
            return "Delivery adddress(es) added successfuly!";
        }
    }
}
