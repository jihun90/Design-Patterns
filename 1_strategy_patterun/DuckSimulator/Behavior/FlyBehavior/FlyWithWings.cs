namespace DuckSimulator.Behavior.FlyBehavior;

public class FlyWithWings : IFlyBehavior
{
    void IFlyBehavior.Fly()
    {
        Console.WriteLine("날고 있어요.");
    }
}
