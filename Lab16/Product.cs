namespace Lab16
{
    public class Product
    {
        public string Description;
        public float Price;
        public string Manufacturer;

        public Product()
        {
            Description = "";
            Manufacturer = "";

        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, Description: {Description}, Price: ${Price}";
        }

    }
}
