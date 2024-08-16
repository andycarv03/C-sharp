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
        public EliteCustomer(string customerId, string customerName, string contactNumber,
            string emailId, string address, int couponsOwned)
            : base(customerId, customerName, contactNumber, emailId, address)
        {
            this.CouponsOwned = couponsOwned;
        }

        public override string GetCustomerDetails()
        {
            string details = null;

            details = base.GetCustomerDetails();
            details += string.Format("{0, -20}: {1}\n", "Coupons Owned", this.CouponsOwned);

            return details;
        }
    }
}
