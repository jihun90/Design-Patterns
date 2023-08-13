namespace PizzaOrderingSystem.PizzaIngredientFactory;

using PizzaOrderingSystem.PizzaIngredientFactory.Ingredient;

public interface PizzaIngredientFactory
{
	public Dough CreateDough();
	public Sauce CreateSauce();
	public Veggie[] CreateVeggies();
	public Cheese CreateCheese();
	public Clams CreateClam();
}