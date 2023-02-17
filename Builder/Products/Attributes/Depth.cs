namespace Furniture.Products.Attributes;

using Contracts;

public class Depth : Dimension {

    internal Depth GetNullValue()
    {
        return new Depth { Value = 0 };
    }
}