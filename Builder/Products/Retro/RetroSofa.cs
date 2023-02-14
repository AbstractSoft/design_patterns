namespace AbstractFactory.Products.Retro;

using Attributes;
using Contracts;

public class RetroSofa : Sofa
{
    public RetroSofa(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}