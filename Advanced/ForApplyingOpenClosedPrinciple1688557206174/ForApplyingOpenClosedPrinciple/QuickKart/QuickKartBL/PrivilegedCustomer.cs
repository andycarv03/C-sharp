using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class PrivilegedCustomer : Customer
    {
        public string MembershipCardType { get; set; }
        public PrivilegedCustomer(string customerId, string customerName, string contactNumber,
            string emailId, string address, string membershipCardType)
            : base(customerId, customerName, contactNumber, emailId, address)
        {
            this.MembershipCardType = membershipCardType;
        }

        public override string GetCustomerDetails()
        {
            string details = null;

            details = base.GetCustomerDetails();
            details += string.Format("{0, -20}: {1}\n", "Membership CardType", this.MembershipCardType);

            return details;
        }
    }
}
