using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer();
            Customer customerTwo = new Customer();
            Customer customerThree = new Customer();

            Console.WriteLine("CustomerOne ID = {0}", customerOne.CustomerId);
            Console.WriteLine("CustomerTwo ID = {0}", customerTwo.CustomerId);
            Console.WriteLine("CustomerThree ID = {0}", customerThree.CustomerId);
        }
    }
}