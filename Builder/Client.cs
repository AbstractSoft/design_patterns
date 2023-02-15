namespace Furniture;

using Factories.Contracts;

public class Client
{
    public void ProduceFurniture(FurnitureFactory factory)
    {
        Console.WriteLine("Start producing furniture...");
        Console.WriteLine();      

        var armchair = factory.MakeArmchair();            

        Console.WriteLine("The {0} was produced!", armchair.ToString());
        Console.WriteLine();

        var sofa = factory.MakeSofa();
            

        Console.WriteLine("The {0} was produced!", sofa.ToString());
        Console.WriteLine();

        var coffeeTable = factory.MakeCoffeeTable();            

        Console.WriteLine("The {0} was produced!", coffeeTable.ToString());
        Console.WriteLine();

        Console.WriteLine("Finish producing furniture...");
        Console.WriteLine();
    }
}