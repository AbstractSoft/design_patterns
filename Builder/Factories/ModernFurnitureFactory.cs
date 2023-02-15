namespace Furniture.Factories;

using Contracts;
using Furniture.Products.Builders;
using Furniture.Products.Retro;
using Products.Contracts;
using Products.Modern;

public class ModernFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair()
    {
        return new ModernArmchair();
    }

    public override CoffeeTable MakeCoffeeTable()
    {
        var coffeeTableBuilder = new CoffeeTableBuilder<ModernCoffeeTable>();
        coffeeTableBuilder.BuildTableLegs();
        coffeeTableBuilder.BuildTablePlate();
        coffeeTableBuilder.BuildTableHandles();

        return coffeeTableBuilder.GetResult();
    }

    public override Sofa MakeSofa()
    {
        return new ModernSofa();
    }
}