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

        public override double GetDiscount()
        {
            return DiscountPercentage;
        }
        public string UpdateDiscountPercentage(double discountPercentage)
        {
            string result = "No updates done on discount percentage!";
            if (discountPercentage >= 0 && discountPercentage <= 100 )
            {
                this.DiscountPercentage = discountPercentage; 
                result = "Discount percentage updated successfully!";
            }
            return result;
        }        
    }
}
