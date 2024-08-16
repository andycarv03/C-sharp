using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class ProductBusinessLogic
    {
        IProductRepository productRepository;
        public ProductBusinessLogic()
        {
            //productRepository = new ProductRepository();
            productRepository = RepositoryFactory.GetProductRepositoryObject();
        }

        public bool AddNewProductDetails(Product product)
        {
            bool repositoryResult = false;
            int validationResult = ValidateProductDetails(product);
            if (validationResult == 1)
            {
                repositoryResult = productRepository.AddNewProduct(product);
            }
            return repositoryResult;
        }

        public Product[] GetProductList()
        {
            return productRepository.GetProductList();
        }

        public int ValidateProductDetails(Product product)
        {
            int validatedResult = 0;
            if (product.ProductId == null || product.ProductName == null)
            {
                validatedResult = -1;
            }
            else if (product.CategoryId <= 0 || product.CategoryId >= 8)
            {
                validatedResult = -2;
            }
            else if (product.Price <= 0 || product.QuantityAvailable < 5)
            {
                validatedResult = -3;
            }
            else
            {
                validatedResult = 1;
            }
            return validatedResult;
        }
    }
}
