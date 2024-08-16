using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class PrivilegedCustomer: Customer
    {
        public string MembershipCardType { get; set; }
        public PrivilegedCustomer(string customerName, string emailId, long contactNumber, string contactAddress,
            string membershipCardType) : base(customerName, emailId, contactNumber, contactAddress)
        {
            MembershipCardType = membershipCardType;
        }

        public string GetCustomerInformation() //Any method marked as ‘override’ can override only a ‘virtual’ method present in the base class.
        {
            string details = base.GetCustomerInformation();
            details += string.Format("\nMembershipCardType = {0}", this.MembershipCardType);
            return details;
        }
    }
}
