using System;
using QuickKartBL;
internal class Program
{
    static void Main(string[] args)
    {
        Customer regularCustomer = new RegularCustomer("John", "john@gmail.com", 8081243129, "Melbourne", 15);
        double discountPercentage = regularCustomer.GetDiscount();
        Console.WriteLine("DiscountPercentage for RegularCustomer = {0}", discountPercentage);

        Customer privilegedCustomer = new PrivilegedCustomer("Catherine", "catherine@gmail.com", 8076453656, "California", "Silver");
        discountPercentage = privilegedCustomer.GetDiscount();
        Console.WriteLine("DiscountPercentage for PrivilegedCustomer = {0}", discountPercentage);

        Customer eliteCustomer = new EliteCustomer("Joey", "joey@gmail.com", 9976053676, "Sydney", 100);
        discountPercentage = eliteCustomer.GetDiscount();
        Console.WriteLine("DiscountPercentage for EliteCustomer = {0}", discountPercentage);
        Console.WriteLine("---------------------------------------------");

        //string result = regularCustomer.UpdateDiscountPercentage(25);
        //Console.WriteLine(result);
        //Console.WriteLine("New Discount Percentage for Regular Customer = {0}", regularCustomer.GetDiscount());

        //New Class called purchase
        Purchase purchase = new Purchase();
        double totalBillAmount = purchase.CalculateTotalBill(regularCustomer, 2500);
        Console.WriteLine("Total Bill Amount for Regular Customer = {0}", totalBillAmount);
        totalBillAmount = purchase.CalculateTotalBill(privilegedCustomer, 3599);
        Console.WriteLine("Total Bill Amount for Privileged Customer = {0}", totalBillAmount);
        totalBillAmount = purchase.CalculateTotalBill(eliteCustomer, 5500);
        Console.WriteLine("Total Bill Amount for Elite Customer = {0}", totalBillAmount);
    }

}
