using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;


namespace QuickKartTestApp
{
    //delegate having return type as double and accepting a double parameter
    //Explicit declaration not required if Func is used
    //public delegate double BirthdayDelegate(double amount);

    //second delegate
    //Explicit declaration not required if Func is used
    //public delegate bool CheckPriceDelegate(Product product);

    class Program
    {
        static void Main(string[] args)
        {
            //BirthdayDelegate discountDel = x => x * 0.2;

            //BirthdayDelegate discountDel = x => Sale.BirthdayDiscount(x);
            Func<double, double> discountDel = x => Sale.BirthdayDiscount(x);

            double discountCustomerOne = discountDel(2500);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerOne);

            double discountCustomerTwo = discountDel(5600);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerTwo);

            double discountCustomerThree = discountDel(4000);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerThree);

            //creating a second delegate instance
            //CheckPriceDelegate checkPrice = p => p.Price > 0;

            //Func taking Product as input and bool as output
            Func<Product, bool> checkPrice = p => p.Price > 0;

            Console.WriteLine();

            Product product = new Product("BasketBall", 1500, 6, 1);
            bool result = checkPrice(product);

            Console.WriteLine("Result = {0}", result);

        }
    }
}
