using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class RepositoryFactory
    {
        public static IProductRepository GetProductRepositoryObject()
        {
            return new ProductRepository();
        }
    }
}
