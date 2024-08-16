using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CustomerDetails
    {
        private static int indexNumber;
        private Customer[] listOfCustomers;

        public CustomerDetails()
        {
            indexNumber = 0;
            listOfCustomers = new Customer[10];
        }

        public bool AddCustomer(Customer customer)
        {
            if(indexNumber < 10 && customer != null) 
            {
                listOfCustomers[indexNumber] = customer;
                indexNumber++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
