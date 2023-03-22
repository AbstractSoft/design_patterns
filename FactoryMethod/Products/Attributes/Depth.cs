namespace Furniture.Products.Attributes;

using Contracts;

public class Depth : Dimension
{

    public static Depth GetNullValue()
    {
        return new Depth { Value = 0 };
    }
}