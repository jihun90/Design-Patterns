namespace Cafe.Condiment;

using Cafe.Beverage;


public class Soy : CondimentDecorator
{
    private readonly double cost = 0.2;
    private readonly string condiment = "Soy";
    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override double GetCost()
    {
        double cost = (this.beverage?.GetCost() ?? 0f);
        BeverageSize size = beverage?.Size ?? BeverageSize.Tall;

        if (size == BeverageSize.Grande)
        {
            cost += 0.1;
        }
        else if(size == BeverageSize.Venti)
        {
            cost += 0.2;
        }

        return cost + this.cost;
    }
    

    public override string GetDescription()
    {
        return (this.beverage?.GetDescription() ?? "") + ", " + condiment;
    }
}