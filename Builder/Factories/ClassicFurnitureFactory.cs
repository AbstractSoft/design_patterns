namespace AbstractFactory.Factories;

using Contracts;
using Products.Attributes;
using Products.Classic;
using Products.Contracts;

public class ClassicFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair(Color color, Width width, Height height, Depth depth)
    {
        return new ClassicArmchair(color, width, height, depth);
    }

    public override CoffeeTable MakeCoffeeTable(Color color, Width width, Height height, Length length)
    {
        return new ClassicCoffeeTable(color, width, height, length);
    }

    public override Sofa MakeSofa(Color color, Width width, Height height, Depth depth)
    {
        return new ClassicSofa(color, width, height, depth);
    }
}