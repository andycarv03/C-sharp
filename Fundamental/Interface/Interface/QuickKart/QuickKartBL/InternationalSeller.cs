using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //Derived class
    public class InternationalSeller: Seller, ITax                   //Seller, Tax (error) | Programmatically, you CANNOT use the relationship 'DomesticSeller IS-A Tax' like DomesticSeller IS-A Seller.
    {
        //Auto-implemented property of derived class. 
        public double ExportCharge { get; set; }

        //Parameterised constructor that calls the base constructor to initialise the properties common to base class.
        public InternationalSeller(string sellerName, string[] sellerLocations, double exportCharge)
            : base(sellerName, sellerLocations)
        {
            ExportCharge = exportCharge;
        }

        //Override the abstract method of base class
        public override double CalculateShippingCharges(string destination)
        {
            double shippingCharges = 0;
            if (SellerLocations.Contains(destination))
            {
                shippingCharges = 1000;
                shippingCharges += ExportCharge;
            }
            else
            {
                shippingCharges = 0;
            }

            return shippingCharges;
        }

        public double PayTax()
        {
            return 15;
        }
    }
}
