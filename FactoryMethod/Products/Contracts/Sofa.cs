namespace Furniture.Products.Contracts;

using Attributes;

public abstract class Sofa : Product
{
    public Width Width { get; init; } = Width.GetNullValue();
    public Height Height { get; init; } = Height.GetNullValue();
    public Depth Depth { get; init; } = Depth.GetNullValue();
}