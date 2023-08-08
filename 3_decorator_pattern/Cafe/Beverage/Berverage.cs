namespace Cafe.Beverage;

public enum BeverageSize
{
    Tall,
    Grande,
    Venti
}


public abstract class Beverage
{
    protected string description = "";
    public virtual string GetDescription()
    {
        return this.description + $"({Size})";
    }
    public abstract double GetCost();

    public BeverageSize Size { get; set; } = BeverageSize.Tall;

}