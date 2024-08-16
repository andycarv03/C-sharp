using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class InternationalSeller: Seller, ITax, IState
    {
        public double ExportCharge { get; set; }
        public InternationalSeller(string sellerName, string[] sellerLocations, double exportCharge)
            : base(sellerName, sellerLocations)
        {
            ExportCharge = exportCharge;
        }

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

        double ITax.PayTax()
        {
            return 30;
        }

        double IState.PayTax()
        {
            return 39;
        }
    }
}
