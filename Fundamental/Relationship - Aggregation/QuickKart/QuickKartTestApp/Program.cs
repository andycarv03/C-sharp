using System;
using QuickKartBL;
internal class Program
{
    /*
     * According to QuickKart requirement, total bill amount to be paid needs to be calculated based on the products added to the cart. Total bill is calculated by fetching the price of every product added to the cart.

In this demo, you will understand how to implement the requirement to fetch the price list using Has-A relationship between the classes Cart and Product. 

     */
    static void Main(string[] args)
    {
        Product productOne = new Product("P131", "Marble chess board", 1, 2000.00, 8);
        Product productTwo = new Product("P132", "Basket Ball", 2, 1000.00, 10);
        Product productThree = new Product("P133", "Carrom Board", 3, 800.00, 2);

        Product[] cartProducts = new Product[] { productOne, productTwo, productThree };
        Cart cartObj = new Cart(cartProducts);
        double[] priceList = cartObj.FetchPriceList();
        Console.WriteLine("------------------");
        Console.WriteLine("Product Price List");
        Console.WriteLine("------------------");
        for (int i = 0; i < priceList.Length; i++)
        {
            Console.WriteLine(priceList[i]);
        }
        Console.WriteLine("------------------");

    }
}
