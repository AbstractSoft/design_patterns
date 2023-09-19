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
        ((Department)engineeringDepartment).Add(employee1);
        ((Department)engineeringDepartment).Add(employee2);
        ((Department)engineeringDepartment).Add(employee3);
        ((Department)hrDepartment).Add(employee4);

        // Create the organization structure
        IOrganizationComponent organization = new Department("Company");
        ((Department)organization).Add(engineeringDepartment);
        ((Department)organization).Add(hrDepartment);

        organization.DisplayInfo();
    }
}