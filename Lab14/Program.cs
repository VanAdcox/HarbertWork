public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sheet: ");
        List<string[]>? data = ReturnCSV("Sheet1.csv");
        if (data == null)
        {
            throw new Exception("Bad Data");
        }

        //sort array by student id & ensure the label is at the top
        data = data.OrderBy(arr => arr[0]).ToList();
        data.Insert(0, data[data.Count - 1]);
        data.RemoveAt(data.Count - 1);


        Dictionary<int, Student> students = CreateStudentDictionary(data);

        Console.WriteLine("\nStudent Data: \n");
        DisplayDataByStudent(students);

        Console.WriteLine("\nStudent Report: ");
        foreach (Student student in students.Values)
        {
            Console.WriteLine($"ID: {student.StudentID}, Infractions: {student.TotalInfractions}, Tardies: {student.Tardies}, Absences: {student.Absences}");
        }
    }
    public static void DisplayDataByStudent(Dictionary<int, Student> data)
    {
        Console.WriteLine($"{"Student".PadRight(20)}{"Date".PadRight(20)}{"Course".PadRight(20)}{"Status".PadRight(20)}");
        foreach (KeyValuePair<int, Student> kv in data)
        {
            Console.WriteLine(kv.Key);
            foreach (string[] row in kv.Value.DataRows)
            {
                Console.WriteLine($"  -> {row[1].PadLeft(20)}{row[2].PadLeft(20)}{row[3].PadLeft(20)}");
            }
        }
    }

    public static Dictionary<int, Student> CreateStudentDictionary(List<string[]> data)
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>();
        foreach (string[] line in data)
        {
            try
            {
                int studentID = int.Parse(line[0]);

                if (!students.ContainsKey(studentID))
                {
                    students.Add(studentID, new Student());
                }
                students[studentID] = AddStudentDataFromLine(students[studentID], line);
            }
            catch
            {
                // is the first line
            }
        }
        return students;
    }

    private static Student AddStudentDataFromLine(Student student, string[] line)
    {
        student.StudentID = int.Parse(line[0]);
        student.DataRows.Add(line);
        if (line[3] == "Tardy")
        {
            student.Tardies++;
        }
        else if (line[3] == "Absent")
        {
            student.Absences++;
        }
        return student;
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
    public struct Student
    {
        public int StudentID { get; set; }
        public int Absences { get; set; }
        public int Tardies { get; set; }
        public int TotalInfractions { get { return Absences + Tardies; } }
        public List<string[]> DataRows { get; set; }

        public Student()
        {
            Absences = 0;
            Tardies = 0;
            DataRows = new List<string[]>();
        }
    }
}
