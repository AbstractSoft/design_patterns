namespace AbstractFactory.Products;

using Attributes;
using Contracts;

public class RetroArmchair : Armchair
{
    public RetroArmchair(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}