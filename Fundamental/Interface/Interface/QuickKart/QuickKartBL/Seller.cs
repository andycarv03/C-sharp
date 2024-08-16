using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //Abstract class. (class containing abstract method must be placed into abstract classes)
    public abstract class Seller
    {
        //Auto-implemented properties
        public string SellerId { get; set; }
        public string SellerName { get; set; }
        public string[] SellerLocations { get; set; }

        //static variable
        static int count;

        //static constructor to initialise static variables
        static Seller()
        {
            //initialise static variable
            count = 1000;
        }

        //parameterless class onstructor
        Seller()
        {
            //increment static variable and assign to SellerID
            count++;
            SellerId = "S" + count;
        }

        //Parameterised constructor thats initialise SellerName/SellerLocations, which inturn calls the parameterless constructor to intialise SellerId instance variable
        public Seller(string sellerName, string[] sellerLocations): this()
        {
            SellerName = sellerName;
            SellerLocations = sellerLocations;
        }

        //Abstract method (which is mandatory to be overidden by the derived class)
        public abstract double CalculateShippingCharges(string destination);

        //Non-abstract method in Abstract class
        public string GetSellerInformation()
        {
            string details = string.Empty;
            string locationDetails = string.Empty;

            details += string.Format("SellerId: {0}\nSellerName: {1}\n", this.SellerId, this.SellerName);
            foreach (string location in this.SellerLocations)
            {
                locationDetails += location + "\n";

            }
            details += string.Format("SellerLocations: \n{0}", locationDetails);

            return details;
        }
    }
}





