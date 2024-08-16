using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    //derived class
    public class EliteCustomer : Customer //is-A or inheritance relationship
    {        
        public int DiscountPercentage { get; set; }
    }
}
