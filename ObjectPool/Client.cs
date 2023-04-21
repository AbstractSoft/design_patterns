namespace Furniture;

internal class Client
{
    private readonly FurnitureShop furnitureShop;
    private ServiceTeam? serviceTeam;

    public Client(FurnitureShop furnitureShop)
    {
        this.furnitureShop = furnitureShop;
    }

    internal void RequestServices(int clientNumber)
    {
        while (serviceTeam == null)
        {
            serviceTeam = furnitureShop.AcquireServiceTeam(clientNumber);
        }
    }

    internal void ServicesDone()
    {
        furnitureShop.ReleaseServiceTeam(serviceTeam);
    }
}