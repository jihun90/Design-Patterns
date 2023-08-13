namespace PizzaOrderingSystem.PizzaIngredientFactory;

using PizzaOrderingSystem.PizzaIngredientFactory.Ingredient;

public class NYPizzaIngredientFactory : PizzaIngredientFactory
{
	public Dough CreateDough()
    {
        return new ThinCrustDough();
    }
	public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }
	public Veggie[] CreateVeggies()
    {
        Veggie[] veggies  = new Veggie[]{ new Garlic(), new Onion(), new Mushroom() };
        return veggies;
    }
	public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }
	public Clams CreateClam()
    {
        return new FreshClams();
    }
}