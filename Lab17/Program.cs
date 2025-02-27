namespace Lab17
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
            Console.WriteLine("computer".StripVowels());

            Product product = new Product { Description = "napkins", Price = 1.50f, Manufacturer = "whoever makes napkins" };
            Product cheap = product.Markdown(.10f); // mark price down 10%
            Console.WriteLine(cheap);
            */

            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            Func<int, int> addOne = x => x + 1;
            DelegateTest.ProcessArray(nums, addOne);
            foreach (int i in nums) { Console.WriteLine(i); }
            Console.WriteLine("");
            Func<int, int> doubleIt = x => x * 2;
            DelegateTest.ProcessArray(nums, doubleIt);
            foreach (int i in nums) { Console.WriteLine(i); }

        }

        //public static int AddOne(int num) { return ++num; }
        //public static int DoubleIt(int num) { return 2 * num; }
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

