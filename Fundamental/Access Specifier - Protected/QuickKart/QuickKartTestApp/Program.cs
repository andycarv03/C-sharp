using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickKartBL;

namespace QuickKartTestApp
{
    /*
     * ‘private’ member is accessible only within its own class
     * ‘protected’ member is accessible only within its own class and its derived class (directly without using an object)
     * 'public' member is accessible within its own class and derived class (directly without using an object)
     * ‘public’ members is also accessible outside its defined class but only when used with an object
     */
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            RegularCustomer regularCustomer = new RegularCustomer();
            EliteCustomer eliteCustomer = new EliteCustomer();
            string result = regularCustomer.UpdateContactDetails("sean@gmail.com", "9807656743", "774, Monterrey");
            Console.WriteLine(result);
            Console.WriteLine("------------------------------------");
            string details = regularCustomer.GetCustomerInformation();
            Console.WriteLine(details);
            Console.ReadLine();
        }

    }
}
