namespace CoffeeOrdering.Decorators;

using Contracts;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", with Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.2;
    }
}