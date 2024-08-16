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

        public EliteCustomer(string customerName, string emailId, long contactNumber, string contactAddress,
            int couponsOwned): base(customerName, emailId, contactNumber, contactAddress)
        {
            CouponsOwned = couponsOwned;
        }
    }
}
