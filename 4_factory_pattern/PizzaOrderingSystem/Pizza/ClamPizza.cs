namespace PizzaOrderingSystem.Pizza;

using PizzaOrderingSystem.PizzaIngredientFactory;

public class CalmPizza : Pizza
{
    private readonly PizzaIngredientFactory ingredientFactory;

    public CalmPizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {		
        if (ingredientFactory == null) return;

        name = "조개피자";
        Console.WriteLine("Preparing " + name);
		dough = ingredientFactory.CreateDough();
		sauce = ingredientFactory.CreateSauce();
		cheese = ingredientFactory.CreateCheese();
		clam = ingredientFactory.CreateClam();
    }
}