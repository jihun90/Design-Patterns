namespace DuckSimulator.Behavior.FlyBehavior;

public class FlyNoWay : IFlyBehavior
{
    void IFlyBehavior.Fly()
    {
        Console.WriteLine("저는 못 날아요...");
    }
}
