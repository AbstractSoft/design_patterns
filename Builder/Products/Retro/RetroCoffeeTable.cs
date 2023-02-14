namespace AbstractFactory.Products.Retro;

using Attributes;
using Contracts;

public class RetroCoffeeTable : CoffeeTable
{
    public RetroCoffeeTable(Color color, Width width, Height height, Length length)
        : base(color, width, height, length)
    {
    }
}