namespace Lab16
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
            /*
            int[] ints = new int[] { 1, 2, 3, 5, 12, 3, -2, 14 };
            Console.WriteLine(ints.Max());

            var mostExpensiveProd = products.MaxBy(prod => prod.Price);
            Console.WriteLine(mostExpensiveProd);

            var count = products.Where(prod => prod.Price > 100).Count();
            Console.WriteLine(count);

            var firstDewalt = products.First(prod => prod.Manufacturer == "Dewalt");
            Console.WriteLine(firstDewalt);
            */

            var expensiveProds = products.ExpensiveItems();
            foreach (Product prod in expensiveProds)
            {
                Console.WriteLine(prod);
            }
        }
    }
    public static class CustomFilters
    {
        public static IEnumerable<Product> ExpensiveItems(this IEnumerable<Product> products)
        {
            float avgPrice = products.Average(prod => prod.Price);
            return products.Where(prod => prod.Price > avgPrice);
        }
    }

}

