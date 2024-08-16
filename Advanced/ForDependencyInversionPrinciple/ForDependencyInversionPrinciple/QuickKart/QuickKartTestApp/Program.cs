using QuickKartBL;

namespace QuickKartTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBusinessLogic productBL = new ProductBusinessLogic();
            Product product = new Product("P101", "Soccer Ball", 1, 1500, 10);
            bool addResult = productBL.AddNewProductDetails(product);
            if (addResult)
            {
                Console.WriteLine("New Product Details Added Successfully to the Repository !");
            }
            else
            {
                Console.WriteLine("Product Details Could Not Be Added to the Repository !!");
            }

            Console.WriteLine("\n-------------------------");
            Console.WriteLine("     Product Details     ");
            Console.WriteLine("-------------------------");
            foreach (Product item in productBL.GetProductList())
            {
                if (item != null)
                {
                    Console.WriteLine("ProductId: {0}\nProductName: {1}\nCategoryId: {2}\n" +
                    "ProductPrice: {3}\nQuantityAvailable: {4}\n",
                    item.ProductId, item.ProductName, item.CategoryId, item.Price, item.QuantityAvailable);
                }
            }
            Console.WriteLine("-------------------------");
        }
    }
}