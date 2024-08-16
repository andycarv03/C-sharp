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

        public RegularCustomer(string customerId, string customerName, string contactNumber,
            string emailId, string address, double discountPercentage)
            : base(customerId, customerName, contactNumber, emailId, address)
        {
            this.DiscountPercentage = discountPercentage;
        }

        public override string GetCustomerDetails()
        {
            string details = null;

            details = base.GetCustomerDetails();
            details += string.Format("{0, -20}: {1}\n", "Discount Percentage", this.DiscountPercentage);

            return details;
        }
    }
}
