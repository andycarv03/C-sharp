using System;
using QuickKartBL;
internal class Program
{
    /*According to QuickKart requirement, you need to calculate the total bill amount to be paid for all the products added to the cart. The total bill amount is calculated based on the price list of all products added to the cart.

In this demo, you will implement the requirement using the Uses-A relationship between the classes Purchase and Cart.*/
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

        Purchase purchase = new Purchase();
        double totalPrice = purchase.CalculateBillAmount(cartObj);
        Console.WriteLine("Total Bill = {0}", totalPrice);
        Console.WriteLine("------------------");
    }
}
