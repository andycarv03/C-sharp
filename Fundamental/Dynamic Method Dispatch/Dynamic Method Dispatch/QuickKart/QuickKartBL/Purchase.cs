using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        //As per requirement to calculate total bill after applying discount amount,
        //the usual way would be to add the following three overloaded methods and implement the code to:

        /* Increaases code redundancy. Code is repeated.
        public double CalculateTotalBill(RegularCustomer regularCustomer, double billAmount)
        {
            double discountAmount = billAmount * (regularCustomer.GetDiscount() / 100);
            double totalBillAmount = billAmount - discountAmount;
            return totalBillAmount;
        }
        public double CalculateTotalBill(PrivilegedCustomer privilegedCustomer, double billAmount)
        {
            double discountAmount = billAmount * (privilegedCustomer.GetDiscount() / 100);
            double totalBillAmount = billAmount - discountAmount;
            return totalBillAmount;
        }
        public double CalculateTotalBill(EliteCustomer eliteCustomer, double billAmount)
        {
            double discountAmount = billAmount * (eliteCustomer.GetDiscount() / 100);
            double totalBillAmount = billAmount - discountAmount;
            return totalBillAmount;
        }
        */

        public double CalculateTotalBill(Customer customer, double billAmount)
        {
            double discountAmount = 0;
            double totalBillAmount = 0;
            //BaseClass bc = new DerivedClass()                             //only public and non-virtual methods are in the scope. Cannot access non-overriden methods of derived class
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
