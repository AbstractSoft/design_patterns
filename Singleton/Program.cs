namespace Singleton;

public class Program
{
    public static void Main()
    {
        var loadBalancer = LoadBalancer.GetInstance();
        
        for (var i = 0; i < 25; i++)
        {
            var server = loadBalancer.GetAvailableServer();
            Console.WriteLine($"Dispatch Request number '{i}' to: {server}");
        }
        
        Console.ReadKey();
    }
}