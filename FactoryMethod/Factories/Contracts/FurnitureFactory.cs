namespace Furniture.Factories.Contracts;

using Products.Contracts;

public abstract class FurnitureFactory
{
    public abstract Armchair MakeArmchair();
    public abstract CoffeeTable MakeCoffeeTable();
    public abstract Sofa MakeSofa();
}