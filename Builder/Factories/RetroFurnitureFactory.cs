namespace Furniture.Factories;

using Contracts;
using Furniture.Products.Builders;
using Products.Contracts;
using Products.Retro;

public class RetroFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair()
    {
        return new RetroArmchair();
    }

    public override CoffeeTable MakeCoffeeTable()
    {
        var coffeeTableBuilder = new CoffeeTableBuilder<RetroCoffeeTable>();
        coffeeTableBuilder.BuildTableLegs();
        coffeeTableBuilder.BuildTablePlate();
        coffeeTableBuilder.BuildTableHandles();

        return coffeeTableBuilder.GetResult();
    }

    public override Sofa MakeSofa()
    {
        return new RetroSofa();
    }
}