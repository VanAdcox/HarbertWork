namespace Program;

public abstract class Animal
{
    private string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    // virtual lets it be overidden, but doesnt' gaurentee it
    public virtual void Sound()
    {
        Console.WriteLine("animal sound");
    }

    // no implenmentation in this class, has to be implemented by child class
    public abstract void Eat();
}

