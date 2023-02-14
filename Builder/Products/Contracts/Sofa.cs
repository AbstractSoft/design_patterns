namespace AbstractFactory.Products.Contracts;

using Attributes;

public abstract class Sofa : Product
{
    protected Sofa(Color color, Width width, Height height, Depth depth)
        : base(color)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public Width Width { get; }
    public Height Height { get; }
    public Depth Depth { get; }
}