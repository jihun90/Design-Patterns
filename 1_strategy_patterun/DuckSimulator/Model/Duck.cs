using DuckSimulator.Behavior.FlyBehavior;
using DuckSimulator.Behavior.QuackBehavior;

namespace DuckSimulator.Model;

public abstract class Duck()
{
    protected IQuackBehavior quackBehavior = new Quack();
    protected IFlyBehavior flyBehavior = new FlyWithWings();

    public void SetQuackBehavior(IQuackBehavior quackBehavior)
    {                   
        if (quackBehavior == null) return;
        this.quackBehavior = quackBehavior;
    }

    public void SetFlyBegavior(IFlyBehavior flyBehavior)
    {
        if (flyBehavior == null) return;
        this.flyBehavior = flyBehavior;
    }

    public void PerformFly()
    {
        if(flyBehavior == null) return;
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        if(quackBehavior == null) return;
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("오리가 수영을 합니다. 가짜 오리도 수영 가능합니다.");
    }
    public abstract void Display();
}