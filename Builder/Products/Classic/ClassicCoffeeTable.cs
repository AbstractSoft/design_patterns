namespace AbstractFactory.Products.Classic;

using Attributes;
using Contracts;

public class ClassicCoffeeTable : CoffeeTable
{
    public ClassicCoffeeTable(Color color, Width width, Height height, Length length)
        : base(color, width, height, length)
    {
    }
}