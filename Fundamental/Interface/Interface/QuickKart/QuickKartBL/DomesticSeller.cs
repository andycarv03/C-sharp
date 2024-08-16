using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //Derived class
    public class DomesticSeller: Seller, ITax
    {
        public bool ExpressDelivery { get; set; }
        public DomesticSeller(string sellerName, string[] sellerLocations,
            bool expressDelivery) : base(sellerName, sellerLocations)
        {
            ExpressDelivery = expressDelivery;
        }

        //Override abstract method of base class
        public override double CalculateShippingCharges(string destination)
        {
            double shippingCharges = 0;
            if (SellerLocations.Contains(destination))
            {
                if (destination.Equals("New York") || destination.Equals("Chicago"))
                {
                    shippingCharges = 50;
                }
                else
                {
                    shippingCharges = 100;
                }
                if (ExpressDelivery)
                {
                    shippingCharges += 250;
                }
            }
            else
            {
                shippingCharges = 0;
            }
            return shippingCharges;
        }

        public double PayTax()
        {
            return 25;
        }
    }
}
