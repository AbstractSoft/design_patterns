namespace Composite;

using Contracts;

/// <summary>
/// Leaf class representing an employee
/// </summary>
public class Employee : IOrganizationComponent
{
    private readonly string _name;
    private readonly string _position;

    public Employee(string name, string position)
    {
        _name = name;
        _position = position;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_position}: {_name}");
    }
}