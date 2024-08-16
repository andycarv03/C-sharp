using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;


//requirement to check the price of a product to be greater than zero, whenever a new product detail needs to store.

//An expression lambda can be used with x as input, where x is the product object. Logic can be x.Price greater than zero as the expression that returns a boolean value.

namespace QuickKartTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<Product> checkPrice = x => x.Price > 0;

            Product product = new Product("Tennis", 1500, 15, 1);

            bool result = checkPrice(product);
            Console.WriteLine("Result : " + result);

        }
    }
}
