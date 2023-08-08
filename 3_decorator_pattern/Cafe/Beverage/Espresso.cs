namespace Cafe.Beverage;

public class Espresso : Beverage
{
    private readonly double cost = 1.0;

    public Espresso()
    {
        description = "Espresso";
    }

    public override double GetCost()
    {
        return this.cost;
    }
}