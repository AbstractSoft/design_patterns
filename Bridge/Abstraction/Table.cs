namespace Bridge.Abstraction;

using Contracts;
using Implementation.Contracts;

public class Table : FurnitureItem
{
    private Table(IMaterial material)
        : base(material)
    {
    }

    // Factory Method
    public static Table MakeTable(IMaterial material)
    {
        return new Table(material);
    }

    public override void Assemble()
    {
        Console.WriteLine("Assembling a table...");
        Material.UseMaterial();
    }
}