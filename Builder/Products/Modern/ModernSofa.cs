namespace AbstractFactory.Products.Modern;

using Attributes;
using Contracts;

public class ModernSofa : Sofa
{
    public ModernSofa(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}