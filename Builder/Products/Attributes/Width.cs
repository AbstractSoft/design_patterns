namespace AbstractFactory.Products.Attributes;

using Contracts;

public class Width : Dimension
{
    public Width(int Value, Metric measurementUnit)
        : base(Value, measurementUnit)
    {
    }
}