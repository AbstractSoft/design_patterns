namespace Bridge.Implementation;

using Contracts;

public class Wood : IMaterial
{
    public void UseMaterial()
    {
        Console.WriteLine("Using wood material for the furniture");
    }
}