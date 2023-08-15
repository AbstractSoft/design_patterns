namespace Bridge.Abstraction.Contracts;

using Implementation.Contracts;

public abstract class FurnitureItem
{
    protected IMaterial Material { get; }

    protected FurnitureItem(IMaterial material)
    {
        Material = material;
    }

    public abstract void Assemble();
}