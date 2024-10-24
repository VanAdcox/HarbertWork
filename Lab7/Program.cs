public class Program
{
    public static void Main(string[] args)
    {
        Payroll payroll = new Payroll();
        payroll.Add(new HourlyEmployee("Joe", "Swanson", "1", 13.50, 40));
        payroll.Add(new HourlyEmployee("Peter", "Griffin", "2", 12.0, 10));
        payroll.Add(new HourlyEmployee("Brian", "Griffin", "3", 13.50, 40));
        // payroll.Add(new SalariedEmployee { FirstName = "Stewie", LastName = "Griffin", EmployeeNumber = "4", Salary = 1000.0 });
        payroll.Add(new SalariedEmployee("Stewie", "Griffin", "4", 1000.0));
        payroll.Add(new SalariedEmployee("Louis", "Griffin", "5", 1200.0));
        payroll.Add(new SalariedEmployee("Meg", "Griffin", "6", 1600.0));

        payroll.Employees[1].PTOTaken = 1;
        payroll.Employees[2].PTOTaken = 3;
        payroll.Employees[3].PTOTaken = 21;
        payroll.Employees[4].PTOTaken = 0;
        payroll.Employees[5].PTOTaken = 9;
        try
        {
            payroll.Employees[0].PTOTaken = 41;
        }
        catch
        {
            Console.WriteLine("Invalid PTO Time, is it over the maximum?");
            Environment.Exit(0);
        }

        payroll.PrintChecks();
    }
}
