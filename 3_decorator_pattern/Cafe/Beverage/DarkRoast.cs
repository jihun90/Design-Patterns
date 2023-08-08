namespace Cafe.Beverage;

public class DarkRoast : Beverage
{
    private readonly double cost = 1.5;

    public DarkRoast()
    {
        description = "DarkRoast";
    }

    public override double GetCost()
    {
        return this.cost;
    }
}