namespace AbstractFactory.Products.Attributes;

using Contracts;

public class Depth : Dimension
{
    public Depth(int Value, Metric measurementUnit)
        : base(Value, measurementUnit)
    {
    }
}