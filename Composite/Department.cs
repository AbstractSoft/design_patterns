namespace Composite;

using Contracts;

/// <summary>
/// Composite class representing a department
/// </summary>
public class Department : IOrganizationComponent
{
    private readonly string _name;
    private readonly List<IOrganizationComponent> _employees = new();

    public Department(string name)
    {
        _name = name;
    }

    public void AddEmployee(IOrganizationComponent employee)
    {
        _employees.Add(employee);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Department: {_name}");
        foreach (var employee in _employees)
        {
            employee.DisplayInfo();
        }
    }
}