namespace AbstractFactory.Products.Contracts;

using Attributes;

public abstract class Product
{
    protected Product(Color color)
    {
        Color = color;
    }

    public Color Color { get; }

    public new string ToString()
    {
        return GetType().Name;
    }
}