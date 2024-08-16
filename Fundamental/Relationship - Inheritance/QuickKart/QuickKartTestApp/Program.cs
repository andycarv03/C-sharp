using System;
using QuickKartBL;
internal class Program
{
    static void Main(string[] args)
    {
        RegularCustomer regularCustomer = new RegularCustomer();
        Console.WriteLine("CustomerId = {0}\nCustomerName = {1}\nEmailId = {2}" +
            "ContactNumber = {3}\nContactAddress = {4}\nDiscountPercentage = {5}",
            regularCustomer.CustomerId, regularCustomer.CustomerName, regularCustomer.EmailId,
            regularCustomer.ContactNumber, regularCustomer.ContactAddress,
            regularCustomer.DiscountPercentage);
        Console.WriteLine("-----------------------");
        EliteCustomer eliteCustomer = new EliteCustomer();
        Console.WriteLine(eliteCustomer.GetCustomerInformation());
    }
}
