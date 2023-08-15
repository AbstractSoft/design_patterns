namespace Bridge;

using Abstraction;
using Implementation;
using Implementation.Contracts;

public class Client
{
    public void RequestWoodFurniture()
    {
        IMaterial wood = new Wood();
        
        var woodenChair = Chair.MakeChair(wood);
        woodenChair.Assemble();
        
        var wodenTable = Table.MakeTable(wood);
        wodenTable.Assemble();
    }

    public void RequestMetalFurniture()
    {
        IMaterial metal = new Metal();
        
        var metalChair = Chair.MakeChair(metal);
        metalChair.Assemble();
        
        var metalTable = Table.MakeTable(metal);
        metalTable.Assemble();
    }
}







