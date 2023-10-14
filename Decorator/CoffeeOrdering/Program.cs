namespace CoffeeOrdering;

using System;
using Contracts;
using Decorators;

class Program
{
    static void Main(string[] args)
    {
        // Create a basic coffee
        ICoffee coffee = new BasicCoffee();

        // Decorate it with extras
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);
        coffee = new VanillaFlavorDecorator(coffee);

        // Display the order
        Console.WriteLine("Order: " + coffee.GetDescription());
        Console.WriteLine("Cost: $" + coffee.GetCost());
    }
}