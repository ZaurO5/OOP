namespace Product
{
    internal class Order
    {
        private Product[] products;
        private int limit { get; }

        public Product[] Products {get => products;}
        public Order()
        {
            products = new Product[0];
            limit = 10;
        }
        public void AddProduct(Product product)
        {
            if(limit > products.Length - 1)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("You are on limit");
            }
        }
        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index; i < products.Length - 1; i++)
                    products[i] = products[i + 1];
                Array.Resize(ref products, products.Length - 1);
            }
            else
            {
                Console.WriteLine("Item is not ");
            }
        }
        public void GetProductDetails()
        {
            foreach (var product in products)
            {
                product.GetDetails();
            }
        }
        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            foreach (var product in products)
            {
                sum += product.Price;
            }
            return sum;
        }
    }
}
