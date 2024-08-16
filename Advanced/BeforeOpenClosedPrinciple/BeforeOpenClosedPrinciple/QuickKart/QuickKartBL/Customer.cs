namespace QuickKartBL
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string CustomerType { get; set; }
        public double DiscountPercentage { get; set; }
        public string MembershipCardType { get; set; }

        //new property
        public int CouponsOwned { get; set; }

        //Customer has a parameterized constructor to initialize all properties using appropriate parameters.
        public Customer(string customerId, string customerName, string contactNumber, 
            string emailId, string address, string customerType,
            double discountPercentage, string membershipCardType, int couponsOwned)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.ContactNumber = contactNumber;
            this.EmailId = emailId;
            this.Address = address;
            this.CustomerType = customerType;
            this.DiscountPercentage = discountPercentage;
            this.MembershipCardType = membershipCardType;

            //new property
            this.CouponsOwned = couponsOwned;
    }

        //method that returns a formatted string with customer details to display based on CustomerType.
        public string GetCustomerDetails()
        {
            string details = null;

            if (this.CustomerType == "RegularCustomer")
            {
                details = string.Format("{0, -20}: {1}\n", "Customer Id", this.CustomerId);
                details += string.Format("{0, -20}: {1}\n", "Customer Name", this.CustomerName);
                details += string.Format("{0, -20}: {1}\n", "ContactNumber", this.ContactNumber);
                details += string.Format("{0, -20}: {1}\n", "Email Id", this.EmailId);
                details += string.Format("{0, -20}: {1}\n", "Address", this.Address);
                details += string.Format("{0, -20}: {1}\n", "Discount Percentage", this.DiscountPercentage);
            }
            if (this.CustomerType == "PrivilegedCustomer")
            {
                details = string.Format("{0, -20}: {1}\n", "Customer Id", this.CustomerId);
                details += string.Format("{0, -20}: {1}\n", "Customer Name", this.CustomerName);
                details += string.Format("{0, -20}: {1}\n", "ContactNumber", this.ContactNumber);
                details += string.Format("{0, -20}: {1}\n", "Email Id", this.EmailId);
                details += string.Format("{0, -20}: {1}\n", "Address", this.Address);
                details += string.Format("{0, -20}: {1}\n", "Membership CardType", this.MembershipCardType);              
            }
            //new property value
            if (this.CustomerType == "EliteCustomer")
            {
                details = string.Format("{0, -20}: {1}\n", "Customer Id", this.CustomerId);
                details += string.Format("{0, -20}: {1}\n", "Customer Name", this.CustomerName);
                details += string.Format("{0, -20}: {1}\n", "ContactNumber", this.ContactNumber);
                details += string.Format("{0, -20}: {1}\n", "Email Id", this.EmailId);
                details += string.Format("{0, -20}: {1}\n", "Address", this.Address);
                details += string.Format("{0, -20}: {1}\n", this.CouponsOwned);
            }

            return details;
        }

        //method to update only contact details irrespective of the CustomerType
        public string UpdateContactDetails(string contactNumber, string emailId, string address)
        {
            if (contactNumber != null)
            {
                this.ContactNumber = contactNumber;
            }
            if (emailId != null)
            {
                this.EmailId = emailId;
            }
            if (address != null)
            {
                this.Address = address;
            }
            return "\nContact Details UPDATED successfully!";
        }
    }
}
