namespace AbstractFactory.Products.Contracts;

using Attributes;

public abstract class CoffeeTable : Product
{
    protected CoffeeTable(Color color, Width width, Height height, Length length)
        : base(color)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    public Width Width { get; }
    public Height Height { get; }
    public Length Length { get; }
}