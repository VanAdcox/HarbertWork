public class Payroll
{
    public List<Employee> Employees = new List<Employee>();

    public void Add(Employee employee)
    {
        Employees.Add(employee);
    }

    public void PrintChecks()
    {
        foreach (Employee emp in Employees)
        {
            Console.WriteLine(emp);
        }
    }
}
