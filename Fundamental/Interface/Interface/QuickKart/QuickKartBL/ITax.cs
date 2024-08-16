using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    /*
     * The requirement for QuickKart is to calculate the payable tax by all the types of sellers and the retailer. 
     * Since only the logic to calculate the tax is different and the signature of the method to be implemented is the same, you can implement another abstract class called as Tax with PayTax as the abstract method.
     * You CANNOT implement the PayTax() in the same abstract class Seller as the class Retailer does not inherit from the Seller class.
     */

    public interface ITax
    {
        //public abstract double PayTax();
        double PayTax();
    }
}
