namespace CoffeeOrdering.Decorators;

using Contracts;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee)
        : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}