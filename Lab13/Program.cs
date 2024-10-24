public class Program
{
    public static void Main(string[] args)
    {
        List<string[]>? data = ReturnCSV("Sheet1.csv");
        if (data != null)
        {
            Display(data);
        }

    }

    public static List<string[]>? ReturnCSV(string filePath)
    {

        List<string[]> results = new List<string[]>();
        try
        {
            StreamReader sr = new StreamReader(filePath);
            string? line = sr.ReadLine();
            while (line != null)
            {
                results.Add(line.Split(","));
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch
        {
            return null;
        }
        return results;
    }
    public static void Display(List<string[]> strings)
    {
        foreach (string[] line in strings)
        {
            foreach (string word in line)
            {
                if (word == "")
                {
                    Console.Write("<unknown>".PadRight(20));
                    continue;
                }
                Console.Write(word.PadRight(20));
            }
            Console.WriteLine();
        }
    }
}
