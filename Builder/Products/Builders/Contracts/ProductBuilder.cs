namespace Furniture.Products.Builders.Contracts;

using Furniture.Products.Contracts;

public abstract class ProductBuilder<T>
    where T : Product
{
    public ProductBuilder() { }

    public abstract T GetResult();
}