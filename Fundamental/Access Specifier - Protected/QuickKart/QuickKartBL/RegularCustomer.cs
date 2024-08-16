using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //derived class
    public class RegularCustomer: Customer //is-A or inheritance relationship
    {
        public int DiscountPercentage { get; set; }
        public string UpdateContactDetails(string emailId, string contactNumber, string contactAddress)
        {
            string result = "Updated contact details succesfully!";
            if (emailId != null)
            {
                base.EmailId = emailId;
            }
            if (contactNumber != null)
            {
                base.ContactNumber = contactNumber;
            }
            if (contactAddress != null)
            {
                base.ContactAddress = contactAddress;
            }
            return result;
        }
    }
}
