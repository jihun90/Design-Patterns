namespace PizzaOrderingSystem.PizzaStore;

using PizzaOrderingSystem.Pizza;

public enum PizzaType { Cheese = 0, Clam = 1, Veggie = 2 }
public abstract class PizzaStore
{

    protected abstract Pizza CreatePizza(PizzaType type);

    public Pizza OrderPizza(PizzaType type)
    {
        Pizza pizza = CreatePizza(type);

        Console.WriteLine("Make Pizza...");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

}