namespace Quiz1
{
    public class Student
    {
        public string Name { get; set; }
        private string major;
        public string Major { get { return major; } }
        private List<int> testScores;
        public double Avg
        {
            get
            {
                if (testScores.Count != 0) { return testScores.Average(); }
                return 0;
            }
        }

        public Student() { this.Name = ""; this.major = ""; this.testScores = new List<int>() { }; }
        public Student(string name, string major) { this.Name = name; this.major = major; this.testScores = new List<int> { }; }


        public void RecordTest(int score) { testScores.Add(score); }

        public virtual string GetDegree() { return $"BS-{major}"; }

        public override string ToString()
        {
            return $"Name: {Name}, Degree: {GetDegree()}, Score: {Avg}";
        }

    }
    public class GradStudent : Student
    {
        private string researchArea;

        public GradStudent() : base() { this.researchArea = "undecided"; }
        public GradStudent(string name, string major, string researchArea) : base(name, major) { this.researchArea = researchArea; }

        public override string GetDegree() { return $"MS-{Major}-{researchArea}"; }

    }

    public class Program
    {
        public static void Main(string[] args)
        {

            List<Student> students = new List<Student> { new Student("bill", "cs") };
            students[0].RecordTest(50);
            students[0].RecordTest(100);

            students.Add(new Student("sue", "chem"));
            students[1].RecordTest(75);
            students[1].RecordTest(85);


            students.Add(new GradStudent("betty", "math", "operations"));


            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            var bStudents = students.Where(student => student.Name.StartsWith("b"));
            foreach (Student student in bStudents)
            {
                Console.WriteLine(student);
            }

        }
    }
}
