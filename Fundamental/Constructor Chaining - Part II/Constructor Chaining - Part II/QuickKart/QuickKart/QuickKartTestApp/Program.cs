using System;
using QuickKartBL;
internal class Program
{
    //In this demo, you will understand how to implement Constructor Chaining.
    //This is an approach where a constructor of one class calls another constructor from the same or base class.
    
    static void Main(string[] args)
    {
        //RegularCustomer regularCustomer = new RegularCustomer();
        RegularCustomer regularCustomer = new RegularCustomer("Tom", "tom@gmail.com", 9876543456, "New Delhi", 15);
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("CustomerID = {0}\nCustomerName = {1}\nEmailId = {2}\n" +
            "ContactNumber = {3}\nContactAddress = {4}\nDiscountPercentage = {5}\n",
            regularCustomer.CustomerId, regularCustomer.CustomerName, regularCustomer.EmailId,
            regularCustomer.ContactNumber, regularCustomer.ContactAddress, regularCustomer.DiscountPercentage);

        EliteCustomer eliteCustomer = new EliteCustomer("Brad", "brad@gmail.com", 9076747851, "Mexico", 100);
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("CustomerID = {0}\nCustomerName = {1}\nEmailId = {2}\n" +
                    "ContactNumber = {3}\nContactAddress = {4}\nCouponsOwned = {5}\n",
                    eliteCustomer.CustomerId, eliteCustomer.CustomerName, eliteCustomer.EmailId,
                    eliteCustomer.ContactNumber, eliteCustomer.ContactAddress, eliteCustomer.CouponsOwned);
    }
    

}