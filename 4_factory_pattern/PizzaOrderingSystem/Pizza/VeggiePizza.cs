namespace PizzaOrderingSystem.Pizza;

using PizzaOrderingSystem.PizzaIngredientFactory;

public class VeggiePizza : Pizza
{
    private readonly PizzaIngredientFactory ingredientFactory;

    public VeggiePizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public override void Prepare()
    {		
        if (ingredientFactory == null) return;
        name = "야채피자";
        Console.WriteLine("Preparing " + name);
		dough = ingredientFactory.CreateDough();
		sauce = ingredientFactory.CreateSauce();
		cheese = ingredientFactory.CreateCheese();
        veggies = ingredientFactory.CreateVeggies();
    }
}