using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product("P131", "Marble chess board", 1, 1099.99, 10);
            
            int discount = 0;           //necessary to initialise before passing discount as a reference variable

            /*
             * Variables passed, should be initialized before the method call 
             * ref keyword must be specified both in the method call and in the method definition
             * A method can have any number of ref parameters
             */
            string result = productOne.CalculateDiscount(ref discount);

            Console.WriteLine(result);
            Console.WriteLine("Discount for the product = {0}", discount);
        }
    }
}