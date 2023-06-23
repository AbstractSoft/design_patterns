namespace Singleton;

public sealed class LoadBalancer
{
    private static readonly Lazy<LoadBalancer> _instance =
        new(() => new LoadBalancer());

    private readonly List<string> _servers = new();
    private readonly Random _random = new();

    private LoadBalancer()
    {
        _servers.Add("Server1");
        _servers.Add("Server2");
        _servers.Add("Server3");
        _servers.Add("Server4");
        _servers.Add("Server5");
    }

    public static LoadBalancer GetInstance() => _instance.Value;

    public string GetAvailableServer()
    {
        var r = _random.Next(_servers.Count);
        return _servers[r];
    }
}