namespace AbstractFactory.Products.Attributes;

using Contracts;

public class Length : Dimension
{
    public Length(int Value, Metric measurementUnit)
        : base(Value, measurementUnit)
    {
    }
}