namespace Furniture.Products.Contracts;

using Attributes;

public abstract class Sofa : Product
{
    public Width Width { get; init; } = default!;
    public Height Height { get; init; } = default!;
    public Depth Depth { get; init; } = default!;
}