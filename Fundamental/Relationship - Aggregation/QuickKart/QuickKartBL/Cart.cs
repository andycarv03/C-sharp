namespace QuickKartBL
{
    public class Cart
    {
        //To implement the requirement, you need to have an array of product objects selected by the customer.
        //Here an array represents the list of products selected for purchase.

        public Product[] CartProducts { get; set; }             //Each object will have the price details to calculate total bill amount.

        public Cart(Product[] products)
        {
            this.CartProducts = products;
        }

        /*The class Cart HAS the Product as data type of the array which can store objects of Product class. 
         * This type of relationship between classes is called Aggregation or Has-A relationship.
         * If a class (Cart) uses another class name (Product) as data type to declare instance variable or a property, 
         * then the relationship between the classes is called as Aggregation.*/

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