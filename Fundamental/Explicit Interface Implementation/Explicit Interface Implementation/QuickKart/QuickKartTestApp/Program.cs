using System;
using QuickKartBL;
namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] domesticLocations = new string[] { "New York", "Raleigh" };
            ITax domesticSeller = new DomesticSeller("David", domesticLocations, true);

            string[] internationalLocations = new string[] { "Dallas", "Kansas", "Chicago" };
            InternationalSeller internationalSeller = new InternationalSeller("Jonathan", internationalLocations, 2500);

            IState iSeller = new InternationalSeller("Jona", internationalLocations, 1500);
            Retailer retailer = new Retailer("R1001", "Fred", "Chicago");

            Console.WriteLine("Tax for DomesticSeller: {0}", domesticSeller.PayTax());
            Console.WriteLine("Tax for InternationalSeller: {0}", iSeller.PayTax());
        }
    }
}
