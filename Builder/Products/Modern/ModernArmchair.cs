namespace AbstractFactory.Products.Modern;

using Attributes;
using Contracts;

public class ModernArmchair : Armchair
{
    public ModernArmchair(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}