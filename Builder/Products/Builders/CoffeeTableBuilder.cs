namespace Furniture.Products.Builders;

using Furniture.Products.Builders.Contracts;
using Furniture.Products.Contracts;

public class CoffeeTableBuilder<T> : ProductBuilder<T>
    where T : CoffeeTable, new()
{
    private readonly T coffeeTable;

    public CoffeeTableBuilder()
    {
        coffeeTable = new T(); 
    }    

    public void BuildTableLegs()
    {
        Console.WriteLine("The table legs for {0} were produced!", coffeeTable.GetType().Name);       
    }

    public void BuildTablePlate()
    {
        Console.WriteLine("The table plate for {0} was produced!", coffeeTable.GetType().Name);
    }

    public void BuildTableHandles()
    {
        Console.WriteLine("The table handles for {0} were produced!", coffeeTable.GetType().Name);
    }

    public override T GetResult()
    {
        return coffeeTable;
    }    
}