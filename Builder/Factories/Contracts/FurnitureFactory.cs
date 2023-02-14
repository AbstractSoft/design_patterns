namespace AbstractFactory.Factories.Contracts;

using Products.Attributes;
using Products.Contracts;

public abstract class FurnitureFactory
{
    public abstract Armchair MakeArmchair(Color color, Width width, Height height, Depth depth);
    public abstract CoffeeTable MakeCoffeeTable(Color color, Width width, Height height, Length length);
    public abstract Sofa MakeSofa(Color color, Width width, Height height, Depth depth);
}