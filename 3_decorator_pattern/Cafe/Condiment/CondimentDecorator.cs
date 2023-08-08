namespace Cafe.Condiment;

using Cafe.Beverage;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage? beverage;
    public override abstract string GetDescription();
}