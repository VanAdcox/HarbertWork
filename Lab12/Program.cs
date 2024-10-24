using System.IO;

namespace Program
{

    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayFile("Text.txt");
            Console.WriteLine();
            DisplayLimitedChars("Text.txt", 4);
            Console.WriteLine();
            DisplayFileBackwards("Text.txt");
            Console.WriteLine();
            CopyFile("Text.txt", "Text2.txt");
        }
        public static void CopyFile(string orig, string copy)
        {
            File.Copy(orig, copy);
        }
        public static void DisplayFileBackwards(string path)
        {
            List<string?> lines = new List<string?>();
            try
            {
                StreamReader sr = new StreamReader(path);
                string? curLine = sr.ReadLine();
                lines.Add(curLine);
                while (curLine != null)
                {
                    curLine = sr.ReadLine();
                    lines.Add(curLine);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            lines.Reverse();
            foreach (string? line in lines)
            {
                Console.WriteLine(line);

            }

        }
        public static void DisplayFile(string path)
        {
            String? line;
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayLimitedChars(string filename, int numChars)
        {
            String? line;
            try
            {
                StreamReader sr = new StreamReader("Text.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line.Substring(0, numChars));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
