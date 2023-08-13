namespace PizzaOrderingSystem.Pizza;

using PizzaOrderingSystem.PizzaIngredientFactory;

public class CheesePizza : Pizza
{
    private readonly PizzaIngredientFactory ingredientFactory;

    public CheesePizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {		
        if (ingredientFactory == null) return;
        name = "치즈피자";
        Console.WriteLine("Preparing " + name);
		dough = ingredientFactory.CreateDough();
		sauce = ingredientFactory.CreateSauce();
		cheese = ingredientFactory.CreateCheese();
    }
}