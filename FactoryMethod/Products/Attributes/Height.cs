namespace Furniture.Products.Attributes;

using Contracts;

public class Height : Dimension
{
    public static Height GetNullValue()
    {
        return new Height { Value = 0 };
    }
}