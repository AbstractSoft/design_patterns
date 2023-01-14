namespace AbstractFactory;

using Factories.Contracts;
using Products.Attributes;
using Products.Attributes.Contracts;

public class Client
{
    public void ProduceFurniture(FurnitureFactory factory)
    {
        Console.WriteLine("Start producing furniture...");
        Console.WriteLine();
        
        var brown = new Color("brown");

        var armchair = factory.MakeArmchair(
            brown,
            new Width(120, Dimension.Metric.Centimeters),
            new Height(140, Dimension.Metric.Centimeters),
            new Depth(60, Dimension.Metric.Centimeters));

        Console.WriteLine("The {0} was produced!", armchair.ToString());
        Console.WriteLine();
        
        var sofa = factory.MakeSofa(
            brown,
            new Width(210, Dimension.Metric.Centimeters),
            new Height(140, Dimension.Metric.Centimeters),
            new Depth(60, Dimension.Metric.Centimeters));

        Console.WriteLine("The {0} was produced!", sofa.ToString());
        Console.WriteLine();

        var coffeeTable = factory.MakeCoffeeTable(
            brown,
            new Width(60, Dimension.Metric.Centimeters),
            new Height(80, Dimension.Metric.Centimeters),
            new Length(100, Dimension.Metric.Centimeters));

        Console.WriteLine("The {0} was produced!", coffeeTable.ToString());
        Console.WriteLine();

        Console.WriteLine("Finish producing furniture...");
        Console.WriteLine();
    }
}