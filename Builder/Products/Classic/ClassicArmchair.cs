namespace AbstractFactory.Products.Classic;

using Attributes;
using Contracts;

public class ClassicArmchair : Armchair
{
    public ClassicArmchair(Color color, Width width, Height height, Depth depth)
        : base(color, width, height, depth)
    {
    }
}