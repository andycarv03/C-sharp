using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public byte CategoryId { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }
        public Product(string productId, string productName, byte categoryId, double price, int quantityAvailable)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.CategoryId = categoryId;
            this.Price = price;
            this.QuantityAvailable = quantityAvailable;
        }
    }
}
