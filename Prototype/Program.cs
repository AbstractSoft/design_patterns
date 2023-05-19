namespace Prototype;

public static class Program
{
    public static void Main(string[] args)
    {
        List<Prototype.Templates.Employee> employeesList = new();

        Prototype.Templates.Employee employee = new();

        var employee1 = employee.Clone();
        employee1.FirstName = "First Name 1";
        employee1.LastName = "Last Name 1";
        employee1.Age = 25;
        employee1.Address = "Employee Address 1";
        
        var employee2 = employee.Clone();
        employee2.FirstName = "First Name 2";
        employee2.LastName = "Last Name 2";
        employee2.Age = 28;
        employee2.Address = "Employee Address 2";
        employee2.Department = Prototype.Templates.Department.Accounting;
        
        employeesList.Add(employee1);
        employeesList.Add(employee2);

        Console.WriteLine("Furniture Shop Employees");
        foreach (var empl in employeesList)
        {
            Console.WriteLine($"Employee: {empl.FirstName}, {empl.LastName} - " +
                              $"{empl.Department}, {empl.Role}, {empl.Position}");
        }
        
        Console.WriteLine("Done.");
        Console.ReadKey();
    }
}