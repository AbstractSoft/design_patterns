namespace Prototype.Templates;

public class Contractor : Person, Prototype.Templates.Contracts.IPrototype<Contractor>
{
    public Contractor()
    {
        Department = Department.None;
        OfficeAddress = "Office Address 1";
        Duration = TimeSpan.FromDays(30);
    }

    public Department Department { get; set; }
    public string OfficeAddress { get; set; }
    
    public TimeSpan Duration { get; set; }
    
    public Contractor Clone()
    {
        var config = new AutoMapper.MapperConfiguration(cfg =>
            cfg.CreateMap<Contractor, Contractor>().ConstructUsing(x => Activator.CreateInstance<Contractor>()));

        config.AssertConfigurationIsValid();

        var mapper = config.CreateMapper();

        return mapper.Map<Contractor, Contractor>(this);
    }
}