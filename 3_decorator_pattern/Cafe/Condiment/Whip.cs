namespace Cafe.Condiment;

using Cafe.Beverage;

public class Whip : CondimentDecorator
{
    private readonly double cost = 0.15;
    private readonly string condiment = "Whip";

    public Whip(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override double GetCost()
    {
        return (this.beverage?.GetCost() ?? 0f) + cost;
    }

    public override string GetDescription()
    {
        return (this.beverage?.GetDescription() ?? "") + ", " + condiment;
    }
}