namespace Prototype.Templates;

public class Employee : Person, Prototype.Templates.Contracts.IPrototype<Employee>
{
    public Employee()
    {
        Department = Department.None;
        Role = Role.Regular;
        Position = "Employee";
        OfficeAddress = "Office Address 1";
        Salary = 5000d;
    }

    public Department Department { get; set; }
    public Role Role { get; set; }
    public string Position { get; set; }
    public string OfficeAddress { get; set; }
    public double Salary { get; set; }

    public Employee Clone()
    {
        var config = new AutoMapper.MapperConfiguration(cfg =>
            cfg.CreateMap<Employee, Employee>().ConstructUsing(x => Activator.CreateInstance<Employee>()));

        config.AssertConfigurationIsValid();

        var mapper = config.CreateMapper();

        return mapper.Map<Employee, Employee>(this);
    }
}