using QuickKartBL;

namespace QuickKartTestApp
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Customer regularCustomer = new RegularCustomer("C101", "Jenny", "9845054609", "jenny@gmail.com",
                "Maple street, 5th cross road", 0.2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       Regular Customer Details       ");
            Console.WriteLine("--------------------------------------");
            string regularCustomerDetails = regularCustomer.GetCustomerDetails();
            Console.WriteLine(regularCustomerDetails);
            Console.WriteLine();

            Customer privilegedCustomer = new PrivilegedCustomer("C102", "Allen", "9708601295", "allen@gmail.com",
                "Park Street, Avenue road", "Gold");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("      Privileged Customer Details     ");
            Console.WriteLine("--------------------------------------");
            string privilegedCustomerDetails = privilegedCustomer.GetCustomerDetails();
            Console.WriteLine(privilegedCustomerDetails);
            Console.WriteLine();

            Customer eliteCustomer = new EliteCustomer("C103", "John", "8509603275", "john@gmail.com",
                "Park Street, Avenue road", 50);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("         Elite Customer Details       ");
            Console.WriteLine("--------------------------------------");
            string eliteCustomerDetails = eliteCustomer.GetCustomerDetails();
            Console.WriteLine(eliteCustomerDetails);
            Console.WriteLine();
        }
    }
}