using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Retailer : ITax
    {
        public string RetailerId { get; set; }
        public string RetailerName { get; set; }
        public string Location { get; set; }
        public Retailer(string retailerId, string retailerName, string location)
        {
            RetailerId = retailerId;
            RetailerName = retailerName;
            Location = location;
        }

        public double PayTax()
        {
            return 5;
        }
    }
}
