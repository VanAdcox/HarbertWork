namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Reptile rep = new Reptile("fluffy", 1.0f);
        rep.Sound();

        Animal[] animals = new Animal[10];

        for (int i = 0; i < 9; i++)
        {
            animals[i] = new Reptile($"ScaleyBoiNum{i + 1}", i / 100f);
        }
        animals[9] = rep;

        Console.WriteLine(animals);
    }
}
