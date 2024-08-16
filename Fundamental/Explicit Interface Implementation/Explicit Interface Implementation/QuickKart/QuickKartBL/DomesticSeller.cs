using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class DomesticSeller: Seller, ITax, IState
    {
        public bool ExpressDelivery { get; set; }
        public DomesticSeller(string sellerName, string[] sellerLocations,
            bool expressDelivery) : base(sellerName, sellerLocations)
        {
            ExpressDelivery = expressDelivery;
        }

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

        double ITax.PayTax()
        {
            return 100;
        }

        double IState.PayTax()
        {
            return 170;
        }

    }
}
