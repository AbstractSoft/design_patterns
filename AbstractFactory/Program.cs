using AbstractFactory;
using AbstractFactory.Factories;

public class Program
{
    public static void Main(string[] args)
    {
        var client = new Client();
        client.ProduceFurniture(new ModernFurnitureFactory());
        client.ProduceFurniture(new RetroFurnitureFactory());
        
    }
}