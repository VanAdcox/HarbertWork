namespace Program;

public class Reptile : Animal
{
    public float Scaly { get; set; }

    public Reptile(string name, float scaly) : base(name)
    {
        Scaly = scaly;
    }

    public override void Sound()
    {
        Console.WriteLine("REPTILEEEEEEEE");
    }

    public override void Eat()
    {
        Console.WriteLine("reptile munch");
    }
}
