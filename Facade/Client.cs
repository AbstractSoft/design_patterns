namespace Multimedia;

using Facade;

internal class Client
{
    static void Main()
    {
        var multimediaFacade = new MultimediaFacade();
       
        Console.WriteLine("Start watching movie");
        multimediaFacade.WatchMovie("Inception", "DTS", "English");

        Console.WriteLine();
        
        Console.WriteLine("Start listening music");
        multimediaFacade.ListenToMusic("Stairway to Heaven");
    }
}