namespace PizzaOrderingSystem.PizzaStore;

using PizzaOrderingSystem.Pizza;
using PizzaOrderingSystem.PizzaIngredientFactory;

public class NewYorkPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(PizzaType type)
    {
        Pizza pizza;
        PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        if (PizzaType.Cheese.Equals(type))
        {
            pizza = new CheesePizza(ingredientFactory);
        }
        else if(PizzaType.Clam.Equals(type))
        {
            pizza = new CalmPizza(ingredientFactory);
        }
        else if(PizzaType.Veggie.Equals(type))
        {
            pizza = new VeggiePizza(ingredientFactory);
        }
        else
        {
            throw new Exception("Can not find pizza type");
        }

        return pizza;
    }
}