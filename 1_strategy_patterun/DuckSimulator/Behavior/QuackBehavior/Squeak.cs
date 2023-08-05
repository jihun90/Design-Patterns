namespace DuckSimulator.Behavior.QuackBehavior;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("삑!");
    }
}
