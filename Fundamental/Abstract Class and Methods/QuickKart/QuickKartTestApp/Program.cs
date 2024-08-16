using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller sellerOne = 
                new DomesticSeller("S1001", 
                "David", 
                new[] { "New York", "Raleigh" }, 
                true);
            Console.WriteLine("New York : " 
                + sellerOne.CalculateShippingCharges("New York"));
            Console.WriteLine("Raleigh : " 
                + sellerOne.CalculateShippingCharges("Raleigh"));
            Console.WriteLine("Chicago : " 
                + sellerOne.CalculateShippingCharges("Chicago"));

            Console.WriteLine("----------------------");
            string details = sellerOne.GetSellerInformation();
            Console.WriteLine(details);


            //Error. cannot instantiate an abstract class. It can be used only to store the reference of a derived class object similar to dynamic polymorphism.
            //Seller seller = new Seller();
        }
    }
}
