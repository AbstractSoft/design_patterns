namespace Furniture.Products.Attributes;

using Contracts;

public class Width : Dimension
{
    public static Width GetNullValue()
    {
        return new Width { Value = 0 };
    }
}