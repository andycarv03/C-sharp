using System;
using QuickKartBL;
internal class Program
{
    static void Main(string[] args)
    {
        PrivilegedCustomer privilegedCustomer = new PrivilegedCustomer("Catherine", "catherine@gmail.com", 8076453656, "California", "Silver");

        string customerInformation = privilegedCustomer.GetCustomerInformation();
        Console.WriteLine(customerInformation);
    }
}
