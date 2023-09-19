namespace Composite;

using Contracts;

/// <summary>
/// Composite class representing a department
/// </summary>
public class Department : IOrganizationComponent
{
    private readonly string _name;
    private readonly List<IOrganizationComponent> _items = new();

    public Department(string name)
    {
        _name = name;
    }

    public void Add(IOrganizationComponent item)
    {
        _items.Add(item);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Department: {_name}");
        foreach (var employee in _items)
        {
            employee.DisplayInfo();
        }
    }
}