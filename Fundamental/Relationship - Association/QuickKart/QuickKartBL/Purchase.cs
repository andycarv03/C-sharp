using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        /*
         *Here the Cart class object is the parameter and is locally available only inside the CalculateBillAmount() method. 
         *This cart object will not be available outside the method, once the method execution is completed.
         *This is a weaker relationship between two classes - Purchase and Cart, where one class object is used within a specified method of another class. 
         *This type of relationship is called as Association or Uses-a relationship. 
         *To implement an association relationship between two classes, an object of one class must be present in another class as a local variable inside the method or as a formal parameter of the method. 
         *
         */
        public double CalculateBillAmount(Cart cart)
        {
            //In order to calculate the total bill amount of all the products that are present in the cart, you can call the FetchPriceList() method using the parameter ‘cart’. 
            double totalPrice = 0;
            double[] priceList = cart.FetchPriceList();
            if (priceList != null)
            {
                for (int i = 0; i < priceList.Length; i++)
                {
                    totalPrice += priceList[i];
                }
            }
            return totalPrice;
        }
    }
}
