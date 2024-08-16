using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public interface IProductRepository
    {
        bool AddNewProduct(Product product);
        bool EditProduct(Product product);
        Product[] GetProductList();
    }
}
