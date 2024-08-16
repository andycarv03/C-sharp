using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;


namespace QuickKartTestApp
{
    //requirement is to check minimum quantity available for a given product. According to the requirement, you can implement a method with the name 'CheckMinimumQuantity'.
    //Pass a Product object and an integer called as minimumExpected as input parameters.
    class Program
    {
        /* commented to use anonynous method
        public static void CheckMinimumQuantity(Product product, int minimumExpected)
        {
            if (product.QuantityAvailable > minimumExpected) 
            {
                Console.WriteLine("Sufficient quantity!");
            }
            else
            {
                Console.WriteLine("Insufficient quantity");
            }
        }
        */
        static void Main(string[] args)
        {
            //In the Main(), the method can be called using an in-built delegate instance 'Func'. But with 'Func' delegate, at least one output parameter type is required and the 'CheckMinimumQuantity' does not return a value.
            //use generic Action delegate instead. The generic Action delegate accepts 16 input types as parameters, but no return type as parameter.

            //Action<Product, int> checkQuantity = (x,y) => CheckMinimumQuantity(x,y);
            Action<Product, int> checkQuantity = (x, y) =>
            {
                if (x.QuantityAvailable > y)
                {
                    Console.WriteLine("Sufficient quantity!");
                }
                else
                {
                    Console.WriteLine("Insufficient quantity");
                }
            };

            Product product = new Product("Tennis Racket", 1500, 15, 1);
            checkQuantity(product, 5);

        }
    }
}
