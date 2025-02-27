namespace Lab17
{
    public static class MyExtensions
    {

        public static string StripVowels(this string str)
        {
            return new string(str.Where(word => !"aeiouAEIOU".Contains(word)).ToArray());
        }
        public static Product Markdown(this Product prod, float markdownPercent)
        {
            return new Product { Description = prod.Description, Price = prod.Price * (1 - markdownPercent), Manufacturer = prod.Manufacturer };
        }
    }
}
