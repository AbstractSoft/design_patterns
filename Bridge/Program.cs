namespace Bridge;

public static class Program
{
    public static void Main()
    {
        Client client = new();
        client.RequestWoodFurniture();
        client.RequestMetalFurniture();
    }
}