namespace Furniture;

public static class Program
{
    public static void Main(string[] args)
    {
        // A bunch of Clients(100) are ordering in the same time
        _ = Parallel.For(0, 100, (i, loopState) =>
        {
            var client = new Client(FurnitureShop.GetInstance());

            try
            {
                client.RequestServices(i + 1);
            }
            finally
            {
                client.ServicesDone();
            }
        });

        Console.WriteLine("Done.");
        Console.ReadKey();
    }
}