using DuckSimulator.Behavior.FlyBehavior;
using DuckSimulator.Behavior.QuackBehavior;

namespace DuckSimulator.Model;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("MallardDuck");
    }
}