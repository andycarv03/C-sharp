using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer regularCustomer = new Customer("C101", "Jenny", "9845054609", "jenny@gmail.com",
                "Maple street, 5th cross road", "RegularCustomer", 0.2, null, 0);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       Regular Customer Details       ");
            Console.WriteLine("--------------------------------------");
            string regularCustomerDetails = regularCustomer.GetCustomerDetails();
            Console.WriteLine(regularCustomerDetails);
            Console.WriteLine();   
            
            Customer privilegedCustomer = new Customer("C102", "Allen", "9708601295", "allen@gmail.com", 
                "Park Street, Avenue road", "PrivilegedCustomer", 0, "Gold", 0);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("      Privileged Customer Details     ");
            Console.WriteLine("--------------------------------------");
            string privilegedCustomerDetails = privilegedCustomer.GetCustomerDetails();
            Console.WriteLine(privilegedCustomerDetails);
            Console.WriteLine();

            Customer eliteCustomer = new Customer("C103", "John", "8509603275", "john@gmail.com",
                "Park Street, Avenue road", "EliteCustomer", 0, null, 50);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("         Elite Customer Details       ");
            Console.WriteLine("--------------------------------------");
            string eliteCustomerDetails = eliteCustomer.GetCustomerDetails();
            Console.WriteLine(eliteCustomerDetails);
            Console.WriteLine();
        }
    }
}
