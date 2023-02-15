namespace Furniture.Products.Contracts;

using Attributes;

public abstract class CoffeeTable : Product
{
    public Width Width { get; init; } = default!;
    public Height Height { get; init; } = default!;
    public Length Length { get; init; } = default!;
}