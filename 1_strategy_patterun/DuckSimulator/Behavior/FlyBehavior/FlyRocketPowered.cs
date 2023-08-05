namespace DuckSimulator.Behavior.FlyBehavior;

public class FlyRocketPowered : IFlyBehavior
{
    void IFlyBehavior.Fly()
    {
        Console.WriteLine("로켓파워로 날아가!");
    }
}
