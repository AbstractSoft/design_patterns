namespace Bridge.Implementation;

using Contracts;

public class Metal : IMaterial
{
    public void UseMaterial()
    {
        Console.WriteLine("Using metal material for the furniture");
    }
}