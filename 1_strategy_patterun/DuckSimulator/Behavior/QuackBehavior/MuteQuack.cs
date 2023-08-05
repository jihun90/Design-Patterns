namespace DuckSimulator.Behavior.QuackBehavior;

public class MuteQuack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Console.WriteLine("[조용]");
    }
}