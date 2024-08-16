using QuickKartBL;
using System;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productObj = new Product("P101", "Samsung Galaxy S4", 1, 38000.00, 10);

            Console.WriteLine("ProductId = {0}\nProductName = {1}\nCategoryId = {2}\n" +
                "Price = {3}\nQuantityAvailable = {4}", productObj.ProductId, productObj.ProductName,
                productObj.CategoryId, productObj.Price, productObj.QuantityAvailable);

            int quantityToPurchase = 2;

            Console.WriteLine("--------------------------------\n");
            if (productObj.CheckAvailability(quantityToPurchase))
            {
                Console.WriteLine("Product is IN STOCK!");
            }
            else
            {
                Console.WriteLine("Product is OUT OF STOCK!!");
            }
            Console.WriteLine("\n--------------------------------");
        }
    }
}