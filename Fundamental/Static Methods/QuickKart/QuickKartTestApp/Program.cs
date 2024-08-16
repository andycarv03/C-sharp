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

            /*
             * static methods are used to access static variables by ClassName.MethodName()
             * static methods cannot be invoked by pbject reference.
             * static methods/variables belong to a class.
             * static method can only access static data. it cannot access non-static data.
             */

            Console.WriteLine("Total number of Customers = {0}", Customer.GetTotalNumberOfCustomer());
        }
    }
}