namespace AbstractFactory.Products.Classic;

using Attributes;
using Contracts;

public class ClassicSofa : Sofa
{
    public ClassicSofa(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}