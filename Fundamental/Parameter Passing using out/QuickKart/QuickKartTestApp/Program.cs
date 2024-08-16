using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product("P131", "Marble chess board", 1, 1099.99, 10);
            
            int discount = 0;
            double minValue;
            double maxValue;

            //use out parameters in the method to return more than one value from the method
            string result = productOne.CalculateDiscount(ref discount, out minValue, out maxValue);

            Console.WriteLine(result);
            Console.WriteLine("Discount for the product = {0}", discount);
            Console.WriteLine("Minimum Price = {0}", minValue);
            Console.WriteLine("Minimum Price = {0}", maxValue);
        }

        /*
         * ref variable must be initialised before passing to called method.
         * Value can be modified before return within called method.
         * 
         * out variable may not be initialised before the called method.
         * must be initialised before return within the called method.
         */
    }
}