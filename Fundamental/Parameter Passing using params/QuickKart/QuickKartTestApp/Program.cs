using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer(1001, "Taylor Swift", "taylor@gmail.com", 9807865432, "723, Amsterdam");
            Customer customerTwo = new Customer(1002, "Harry Styles", "harry@gmail.com", 8679321789, "675, Italy");
            Customer customerThree = new Customer(1003, "Justin Bieber", "justin@gmail.com", 9909311780, "301, Newark");

            //use params keyword for passing variable number of parameters to a method and implement the above mentioned requirement.
            /* Req : According to the requirement, there should be more properties (or fields) required to store different delivery addresses.
             * But there is only one ContactAddress, to store the customer contact address.
             */

            //This just increases the code length. Instead you can use these addresses passed as parameters directly to the method.

            //string[] DeliveryAddressOne = new string[] { "Netherlands" };
            //customerOne.AddDeliveryAddress(DeliveryAddressOne);

            //string[] DeliveryAddressTwo = new string[] { "Netherlands" , "Italy" , "Switzerland"};
            //customerTwo.AddDeliveryAddress(DeliveryAddressTwo);

            //string[] DeliveryAddressThree = new string[] { "Netherlands", "Italy", "Switzerland" , "Greenland", "Norway", "Prague"};
            //customerThree.AddDeliveryAddress(DeliveryAddressThree);

            string DeliveryAddresses = customerOne.AddDeliveryAddress("Netherlands");
            Console.WriteLine(DeliveryAddresses);

            DeliveryAddresses = customerTwo.AddDeliveryAddress("Netherlands", "Italy", "Switzerland");
            Console.WriteLine(DeliveryAddresses);

            DeliveryAddresses = customerThree.AddDeliveryAddress("Netherlands", "Italy", "Switzerland", "Greenland", "Norway", "Prague");
            Console.WriteLine(DeliveryAddresses);

            foreach (string item in customerThree.DeliveryAddress)
            {
                Console.WriteLine(item);
            }


            /*
             * 'params' is always used with an array to hold variable length of parameter values 
             * If you do not send any arguments, the length of the params list will be zero
             * No additional parameters are permitted after the params keyword in the method declaration
             * Only one params keyword is permitted in a method declaration 
             */
        }
    }
}