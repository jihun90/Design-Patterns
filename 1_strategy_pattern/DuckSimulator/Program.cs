using DuckSimulator.Behavior.FlyBehavior;
using DuckSimulator.Behavior.QuackBehavior;
using DuckSimulator.Model;

namespace DuckSimulator;
class Program
{
    static void Main()
    {
        Duck mallardDuck = new MallardDuck();
        Duck redheadDuck = new RedheadDuck();
        Duck rubberDuck = new RubberDuck();

        List<Duck> duckList = new List<Duck>
        {
            mallardDuck,
            redheadDuck,
            rubberDuck
        };

        duckList.ForEach(duck => 
        {
            Console.WriteLine("설명 시작");    
            duck.Display();
            duck.Swim();
            duck.PerformFly();
            duck.PerformQuack();
            Console.WriteLine("설명 끝");}
        );

        rubberDuck.SetFlyBegavior(new FlyRocketPowered());
        Console.WriteLine("설명 시작");    
        rubberDuck.Display();
        rubberDuck.Swim();
        rubberDuck.PerformFly();
        rubberDuck.PerformQuack();
        Console.WriteLine("설명 끝");}
}

