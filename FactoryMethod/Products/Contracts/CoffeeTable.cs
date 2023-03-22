namespace Furniture.Products.Contracts;

using Attributes;

public abstract class CoffeeTable : Product
{
    public Width Width { get; init; } = Width.GetNullValue();
    public Height Height { get; init; } = Height.GetNullValue();
    public Length Length { get; init; } = Length.GetNullValue();
}