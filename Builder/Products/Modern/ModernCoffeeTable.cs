namespace AbstractFactory.Products.Modern;

using Attributes;
using Contracts;

public class ModernCoffeeTable : CoffeeTable
{
    public ModernCoffeeTable(Color color, Width width, Height height, Length length)
        : base(color, width, height, length)
    {
    }
}