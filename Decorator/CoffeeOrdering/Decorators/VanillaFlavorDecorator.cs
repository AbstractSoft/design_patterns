namespace CoffeeOrdering.Decorators;

using Contracts;

public class VanillaFlavorDecorator : CoffeeDecorator
{
    public VanillaFlavorDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Vanilla Flavor";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.7;
    }
}