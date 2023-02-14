namespace AbstractFactory.Factories;

using Contracts;
using Products;
using Products.Attributes;
using Products.Contracts;
using Products.Retro;

public class RetroFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair(Color color, Width width, Height height, Depth depth)
    {
        return new RetroArmchair(color, width, height, depth);
    }

    public override CoffeeTable MakeCoffeeTable(Color color, Width width, Height height, Length length)
    {
        return new RetroCoffeeTable(color, width, height, length);
    }

    public override Sofa MakeSofa(Color color, Width width, Height height, Depth depth)
    {
        return new RetroSofa(color, width, height, depth);
    }
}