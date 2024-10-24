public class Program()
{
    public static void Main(string[] args)
    {
        int? x1;
        int? x2;
        x1 = 20;
        x2 = null;
        M(x1);
        M(x2);
    }

    public static void M(int? x)
    {
        if (x.HasValue) { Console.WriteLine(x); }
        else { Console.WriteLine("int has no value"); }
    }
}
