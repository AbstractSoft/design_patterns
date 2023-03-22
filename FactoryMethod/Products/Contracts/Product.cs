namespace Furniture.Products.Contracts;

using Attributes;

public abstract class Product
{
    public Color Color { get; init; } = Color.GetNullValue();

    public new string ToString()
    {
        return GetType().Name;
    }
}