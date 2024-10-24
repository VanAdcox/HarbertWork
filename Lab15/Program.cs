namespace Lab15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product[] products = new Product[] {
                new Product { Description = "chair", Price = 200.0f, Manufacturer = "Ashley" },
                new Product { Description = "hammer", Price = 10.00f, Manufacturer = "Dewalt" },
                new Product { Description = "box", Price = 5.00f, Manufacturer = "Able" },
                new Product { Description = "saw", Price = 150.00f, Manufacturer = "Dewalt" },
                new Product { Description = "table", Price = 400.0f, Manufacturer = "Ashley" }
            };
            var orderedByManu = from product in products
                                group product by product.Manufacturer into manufacturerProducts
                                orderby manufacturerProducts.Key
                                select manufacturerProducts;
            foreach (var manuProds in orderedByManu)
            {
                Console.WriteLine(manuProds.Key);
                foreach (Product prod in manuProds)
                {
                    Console.WriteLine($"\t{prod.Description}\t${prod.Price}");
                }
            }

        }
    }
}

