using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public sealed class Purchase
    {
        public double CalculateTotalBill(Customer customer, double billAmount)
        {
            double discountAmount = 0;
            double totalBillAmount = 0;

            if (customer is RegularCustomer || customer is PrivilegedCustomer)
            {
                discountAmount = billAmount * (customer.GetDiscount() / 100);
                totalBillAmount = billAmount - discountAmount;
            }
            if (customer is EliteCustomer)
            {
                EliteCustomer eliteCustomer = customer as EliteCustomer;
                discountAmount = eliteCustomer.CouponsOwned;
                totalBillAmount = billAmount - discountAmount;
            }
            return totalBillAmount;
        }
    }
}
