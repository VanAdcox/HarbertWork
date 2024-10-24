public abstract class Employee
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmployeeNumber { get; set; }

    public const int MaxPTO = 30;
    private int ptoTaken = 0;
    public int PTOTaken
    {
        get { return ptoTaken; }
        set
        {
            if (value < MaxPTO)
            {
                ptoTaken = value;
            }
            else
            {
                throw new ArgumentException("a");
            }
        }
    }
    public Employee(string fName, string lName, string empNum)
    {
        FirstName = fName;
        LastName = lName;
        EmployeeNumber = empNum;
        PTOTaken = 0;
    }

    public abstract double GetPay();

    public override string ToString()
    {
        return $"Name: {FirstName}, {LastName}, Employee Number: {EmployeeNumber}, PTO: {ptoTaken}/{MaxPTO}";
    }
}

public class SalariedEmployee : Employee
{
    public double Salary { get; set; }

    public SalariedEmployee(string fName, string lName, string empNum, double salary) : base(fName, lName, empNum)
    {
        Salary = salary;
    }

    public override double GetPay()
    {
        return Salary;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, ${Salary}";
    }
}

public class HourlyEmployee : Employee
{
    public double HourlyPay { get; set; }
    public int HoursWeekly { get; set; }

    public HourlyEmployee(string fName, string lName, string empNum, double hourlyPay, int hoursWeekly) : base(fName, lName, empNum)
    {
        HourlyPay = hourlyPay;
        HoursWeekly = hoursWeekly;
    }

    public override double GetPay()
    {
        return HoursWeekly * HourlyPay;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Hourly pay: ${HourlyPay}, Hours: {HoursWeekly}";
    }
}
