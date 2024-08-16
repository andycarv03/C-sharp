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

        public override double GetDiscount()
        {
            double discountPercentage = 0;
            switch (this.MembershipCardType)
            {
                case "Silver":
                    discountPercentage = 5; 
                    break;
                case "Gold":
                    discountPercentage = 10;
                    break;
                case "Platinum":
                    discountPercentage = 15;
                    break;
                default:
                    discountPercentage = 0;
                    break;
            }
            return discountPercentage;
        }
        public string UpdateMembershipCardType(string cardType)
        {
            string result = "No updates done on membership card type!";
            if (cardType == "Silver" || cardType == "Gold" || cardType == "Platinum")
            {
                this.MembershipCardType = cardType;
                result = "Membership Card Type updated successfully!";
            }
            return result;
        }
    }
}
