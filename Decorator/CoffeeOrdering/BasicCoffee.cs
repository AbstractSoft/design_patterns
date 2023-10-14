namespace CoffeeOrdering;

using Contracts;

// Concrete Component (Basic Coffee)
public class BasicCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Basic Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}