using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Product
    {
        //Auto-implemented properties
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public byte CategoryId { get; set; }
        public double Price { get; set; }
        public int QuantityAvailabe { get; set; }

        public Product(string productId, string productName, byte categoryId, double price, int quantityAvailable)
        {
            ProductId = productId;
            ProductName = productName;
            CategoryId = categoryId;        
            Price = price;
            QuantityAvailabe = quantityAvailable;
        }

        public string CalculateDiscount(ref int discount, out double minPrice, out double maxPrice)
        {
            string result = "Eligible for discount";

            if (this.Price <= 500)
            {
                minPrice = 1;
                maxPrice = 500;
                result = "Not eligible for discount";
            }
            else if (this.Price > 500 && this.Price <= 1000)
            {
                discount = 5;
                minPrice = 501;
                maxPrice = 1000;
            }
            else if (this.Price > 1000 && this.Price <= 5000)
            {
                discount = 10;
                minPrice = 1001;
                maxPrice = 5000;
            }
            else if (this.Price > 5000 && this.Price <= 10000)
            {
                discount = 15;
                minPrice = 5001;
                maxPrice = 10000;
            }
            else
            {
                minPrice = 10001;
                maxPrice = double.MaxValue;
                discount = 20;
            }

            return result;
        }
    }
}
