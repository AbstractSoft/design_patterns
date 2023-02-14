namespace AbstractFactory.Factories;

using Contracts;
using Products.Attributes;
using Products.Contracts;
using Products.Modern;

public class ModernFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair(Color color, Width width, Height height, Depth depth)
    {
        return new ModernArmchair(color, width, height, depth);
    }

    public override CoffeeTable MakeCoffeeTable(Color color, Width width, Height height, Length length)
    {
        return new ModernCoffeeTable(color, width, height, length);
    }

    public override Sofa MakeSofa(Color color, Width width, Height height, Depth depth)
    {
        return new ModernSofa(color, width, height, depth);
    }
}