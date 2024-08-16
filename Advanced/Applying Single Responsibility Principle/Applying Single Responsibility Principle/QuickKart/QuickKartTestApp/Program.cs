using QuickKartBL;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("C101", "Jenny", "9845054609", "jenny@gmail.com",
                "Maple street, 5th cross road");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("           Customer Details           ");
            Console.WriteLine("--------------------------------------");
            string customerDetails = customer.GetCustomerDetails();
            Console.WriteLine(customerDetails);

            string updateStatus = customer.UpdateContactDetails("9995094609",
                "jenny123@gmail.com", null);
            Console.WriteLine(updateStatus);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("       Updated Customer Details       ");
            Console.WriteLine("--------------------------------------");
            customerDetails = customer.GetCustomerDetails();
            Console.WriteLine(customerDetails);

            PersistCustomerDetails persistDetails = new PersistCustomerDetails(customer);
            string saveStatus = persistDetails.SaveCustomerDetails();
            Console.WriteLine(saveStatus);
        }
    }
}