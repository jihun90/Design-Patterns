namespace Cafe.Beverage;

public class Decafe : Beverage
{
    private readonly double cost = 2.0;

    public Decafe()
    {
        description = "Decafe";
    }

    public override double GetCost()
    {
        return this.cost;
    }
}