using DuckSimulator.Behavior.FlyBehavior;
using DuckSimulator.Behavior.QuackBehavior;

namespace DuckSimulator.Model;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        quackBehavior = new MuteQuack();
        flyBehavior = new FlyNoWay();
    }

    public override void Display()
    {
        Console.WriteLine("RubberDuck");
    }
}