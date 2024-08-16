using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class RegularCustomer : Customer
    {
        public double DiscountPercentage { get; set; }
        public RegularCustomer(string customerName, string emailId, long contactNumber, string contactAddress,
            int discount): base(customerName, emailId, contactNumber, contactAddress)
        {
            DiscountPercentage = discount;
        }
    }
}
