namespace Furniture;

using System.Collections.Concurrent;

internal class FurnitureShop
{
    private const int MaxTeamsNumber = 5;

    private static int teamNumber;
    static readonly object locker = new();

    private readonly ConcurrentBag<ServiceTeam> items = new();

    private static readonly Lazy<FurnitureShop> lazy =
        new(() => new FurnitureShop());

    private FurnitureShop()
    {
    }

    internal static FurnitureShop GetInstance() => lazy.Value;

    internal ServiceTeam AcquireServiceTeam(int clientNumber)
    {
        lock (locker)
        {
            if (items.TryTake(out var serviceTeam))
            {
                Console.WriteLine("Service team {0} requested by client {1}.", serviceTeam.TeamNubmer, clientNumber);
            }

            if (teamNumber < MaxTeamsNumber)
            {
                serviceTeam = new ServiceTeam(++teamNumber);
                Console.WriteLine("Service team {0} requested by client {1}.", serviceTeam.TeamNubmer, clientNumber);
            }

            return serviceTeam!;
        }
    }

    internal void ReleaseServiceTeam(ServiceTeam item)
    {
        lock (locker)
        {
            if (items.Contains(item))
            {
                return;
            }

            items.Add(item);
            Console.WriteLine("Service team {0} is available.", item.TeamNubmer);
        }
    }
}