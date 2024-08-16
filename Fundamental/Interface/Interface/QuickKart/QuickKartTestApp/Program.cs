using System;
using QuickKartBL;
namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] domesticLocations = new string[] { "New York", "Raleigh" };
            DomesticSeller domesticSeller = new DomesticSeller("David", domesticLocations, true);

            Console.WriteLine("----------------------");
            Console.WriteLine("   Domestic Shipping Charges   ");
            Console.WriteLine("----------------------");
            Console.WriteLine("New York: " + domesticSeller.CalculateShippingCharges("New York"));
            Console.WriteLine("Chicago : " + domesticSeller.CalculateShippingCharges("Chicago"));
            Console.WriteLine("Raleigh : " + domesticSeller.CalculateShippingCharges("Raleigh"));

            Console.WriteLine("----------------------");
            string details = domesticSeller.GetSellerInformation();
            Console.WriteLine(details);

            //string[] domesticLocations = new string[] { "New York", "Raleigh" };
            //DomesticSeller domesticSeller = new DomesticSeller("David", domesticLocations, true);
            string[] internationalLocations = new string[] { "Dallas", "Kansas", "Chicago" };
            InternationalSeller internationalSeller = new InternationalSeller("Jonathan", internationalLocations, 2500);
            Console.WriteLine("----------------------");
            Console.WriteLine("   Intl Shipping Charges   ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Dallas : " + internationalSeller.CalculateShippingCharges("Dallas"));
            Console.WriteLine("Kansas : " + internationalSeller.CalculateShippingCharges("Kansas"));
            Console.WriteLine("Chicago : " + internationalSeller.CalculateShippingCharges("Chicago"));

            Console.WriteLine("----------------------");
            Retailer retailerOne = new Retailer("R1001", "Fred", "Chicago");

            Console.WriteLine("Tax for DomesticSeller : " + domesticSeller.PayTax());
            Console.WriteLine("Tax for InternationalSeller : " + internationalSeller.PayTax());
            Console.WriteLine("Tax for first Retailer : " + retailerOne.PayTax());
        }
    }
}
