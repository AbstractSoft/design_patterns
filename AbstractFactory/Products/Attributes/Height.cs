namespace Furniture.Products.Attributes;

using Contracts;

public class Height : Dimension
{
    public Height(int Value, Metric measurementUnit)
        : base(Value, measurementUnit)
    {
    }
}