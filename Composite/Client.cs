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
        IOrganizationComponent engineeringDepartment = new OrganizationalUnit("Engineering");
        IOrganizationComponent hrDepartment = new OrganizationalUnit("HR");

        // Add employees to departments
        ((OrganizationalUnit)engineeringDepartment).Add(employee1);
        ((OrganizationalUnit)engineeringDepartment).Add(employee2);
        ((OrganizationalUnit)engineeringDepartment).Add(employee3);
        ((OrganizationalUnit)hrDepartment).Add(employee4);

        // Create the organization structure
        IOrganizationComponent organization = new OrganizationalUnit("Company");
        ((OrganizationalUnit)organization).Add(engineeringDepartment);
        ((OrganizationalUnit)organization).Add(hrDepartment);

        organization.DisplayInfo();
    }
}