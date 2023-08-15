namespace Bridge.Abstraction;

using Contracts;
using Implementation.Contracts;

public class Chair : FurnitureItem
{
    private Chair(IMaterial material)
        : base(material)
    {
    }

    // Factory Method
    public static Chair MakeChair(IMaterial material)
    {
        return new Chair(material);
    }

    public override void Assemble()
    {
        Console.WriteLine("Assembling a chair...");
        Material.UseMaterial();
    }
}