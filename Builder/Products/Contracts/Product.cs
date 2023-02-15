namespace Furniture.Products.Contracts;

using Attributes;

public abstract class Product
{
    public Color Color { get; init; } = default!;

    public new string ToString()
    {
        return GetType().Name;
    }
}