namespace Composite;

using Contracts;

public abstract class Client
{
    public static void DisplayOrganizationInfo()
    {
        // Create employees
        IOrganizationComponent employee1 = new Employee("John Doe", "Manager");
        IOrganizationComponent employee2 = new Employee("Alice Smith", "Engineer");
        IOrganizationComponent employee3 = new Employee("Bob Johnson", "Engineer");
        IOrganizationComponent employee4 = new Employee("Eve Williams", "Manager");

        // Create departments
        IOrganizationComponent engineeringDepartment = new Department("Engineering");
        IOrganizationComponent hrDepartment = new Department("HR");

        // Add employees to departments
        ((Department)engineeringDepartment).AddEmployee(employee1);
        ((Department)engineeringDepartment).AddEmployee(employee2);
        ((Department)engineeringDepartment).AddEmployee(employee3);
        ((Department)hrDepartment).AddEmployee(employee4);

        // Create the organization structure
        IOrganizationComponent organization = new Department("Company");
        ((Department)organization).AddEmployee(engineeringDepartment);
        ((Department)organization).AddEmployee(hrDepartment);

        organization.DisplayInfo();
    }
}