using DuckSimulator.Behavior.FlyBehavior;
using DuckSimulator.Behavior.QuackBehavior;

namespace DuckSimulator.Model;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        quackBehavior = new Quack();
        flyBehavior = new FlyWithWings();
    }  
      
    public override void Display()
    {
        Console.WriteLine("RedheadDuck");
    }
}