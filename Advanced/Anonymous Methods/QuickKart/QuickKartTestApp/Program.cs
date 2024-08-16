using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;


namespace QuickKartTestApp
{
    public delegate double BirthdayDelegate(double amount);
    class Program
    {
        static void Main(string[] args)
        {
            //BirthdayDelegate discountDel = Sale.BirthdayDiscount;
            BirthdayDelegate discountDel = delegate (double amount)
            {
                double discountAmount = amount * 0.2;
                return discountAmount;
            };
            //With this, you have converted a method with a name to a method without a name.
            //Such methods are called as Anonymous methods. Anonymous methods are similar to anonymous class created without a name.
            double discountCustomerOne = discountDel(2500);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerOne);
            double discountCustomerTwo = discountDel(5600);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerTwo);

            double discountCustomerThree = discountDel(4000);
            Console.WriteLine("Amount after applying 20% discount = " + discountCustomerThree);

        }
    }
}
