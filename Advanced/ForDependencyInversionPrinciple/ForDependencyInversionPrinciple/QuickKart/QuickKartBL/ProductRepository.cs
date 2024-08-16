using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class ProductRepository : IProductRepository
    {
        public static Product[] ProductList { get; set; }
        public int Size { get; set; }
        public int IndexNumber { get; set; }
        public ProductRepository()
        {
            Size = 10;
            ProductList = new Product[Size];
            IndexNumber = 0;
        }
        public bool AddNewProduct(Product product)
        {
            bool addResult = false;
            if (IndexNumber < Size)
            {
                ProductList[IndexNumber++] = product;
                addResult = true;
            }
            return addResult;
        }
        public bool EditProduct(Product product)
        {
            bool editResult = false;
            for (int i = 0; i < ProductList.Length; i++)
            {
                Product productObj = ProductList[i];
                if (productObj.ProductId == product.ProductId)
                {
                    ProductList[i] = product;
                    editResult = true;
                    break;
                }
            }
            return editResult;
        }
        public Product[] GetProductList()
        {
            return ProductList;
        }
    }
}
