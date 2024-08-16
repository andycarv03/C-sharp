namespace QuickKartBL
{
    public class Cart
    {
        public Product[] CartProducts { get; set; }
        public Cart(Product[] products)
        {
            this.CartProducts = products;
        }
        public double[] FetchPriceList()
        {
            double[] priceList = null;
            if (this.CartProducts != null)
            {
                priceList = new double[CartProducts.Length];
                for (int i = 0; i < CartProducts.Length; i++)
                {
                    priceList[i] = CartProducts[i].Price;
                }
            }
                        
            return priceList;
        }
    }
}