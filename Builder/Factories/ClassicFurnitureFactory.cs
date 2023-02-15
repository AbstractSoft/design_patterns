namespace Furniture.Factories;

using Contracts;
using Furniture.Products.Builders;
using Furniture.Products.Modern;
using Products.Classic;
using Products.Contracts;

public class ClassicFurnitureFactory : FurnitureFactory
{
    public override Armchair MakeArmchair()
    {
        return new ClassicArmchair();
    }

    public override CoffeeTable MakeCoffeeTable()
    {
        var coffeeTableBuilder = new CoffeeTableBuilder<ClassicCoffeeTable>();
        coffeeTableBuilder.BuildTableLegs();
        coffeeTableBuilder.BuildTablePlate();
        coffeeTableBuilder.BuildTableHandles();

        return coffeeTableBuilder.GetResult();
    }

    public override Sofa MakeSofa()
    {
        return new ClassicSofa();
    }
}