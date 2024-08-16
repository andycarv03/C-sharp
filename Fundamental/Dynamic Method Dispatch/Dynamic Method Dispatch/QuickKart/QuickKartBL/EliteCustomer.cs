using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class EliteCustomer : Customer
    {
        public int CouponsOwned { get; set; }

        public EliteCustomer(string customerName, string emailId, long contactNumber, string contactAddress,
            int couponsOwned): base(customerName, emailId, contactNumber, contactAddress)
        {
            CouponsOwned = couponsOwned;
        }

        public string UpdateCouponsOwned(int couponsGiven)
        {
            string result = "No updates done on Coupons Owned!";
            if (couponsGiven > 0)
            {
                this.CouponsOwned += couponsGiven;
                result = "Coupons Owned updated successfully!";
            }
            return result;
        }
    }
}
