namespace CoffeeOrdering.Contracts;

// Decorator abstract class
public abstract class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}