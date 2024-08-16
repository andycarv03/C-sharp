using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class PersistCustomerDetails
    {
        public Customer Customer { get; set; }

        public PersistCustomerDetails(Customer customer) 
        {
            this.Customer = customer;
        }

        public string SaveCustomerDetails()
        {
            string path = @"C:\Users\andyc\Downloads\CustomerDetails.txt";
            FileStream fileStream = null;
            bool result = File.Exists(path);

            if (result)
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Write);
            else
                fileStream = new FileStream(path, FileMode.CreateNew, FileAccess.Write);

            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("{0}, {1}, {2}, {3}, {4}",
                Customer.CustomerId, Customer.CustomerName, Customer.ContactNumber, Customer.EmailId, Customer.Address);
            writer.Close();
            return "\nDetails SAVED successfully in a file!\n";
        }


    }
}
