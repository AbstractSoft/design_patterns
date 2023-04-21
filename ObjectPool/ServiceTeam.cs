namespace Furniture;

using System.ComponentModel.Design.Serialization;

internal class ServiceTeam
{
    internal ServiceTeam(int teamNumber)
    {
        TeamNubmer = teamNumber;

        PutOnTheOverall();
        PrepareRequiredTools();
        TakeTheTruckFromGarage();
    }

    private void PrepareRequiredTools() => Thread.Sleep(500);
    private void TakeTheTruckFromGarage() => Thread.Sleep(500);
    private void PutOnTheOverall() => Thread.Sleep(500);

    internal int TeamNubmer { get; }
}