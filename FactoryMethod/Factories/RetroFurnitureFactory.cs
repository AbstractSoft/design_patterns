namespace Furniture.Factories;

using Contracts;
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
        return new RetroCoffeeTable();
    }

    public override Sofa MakeSofa()
    {
        return new RetroSofa();
    }
}