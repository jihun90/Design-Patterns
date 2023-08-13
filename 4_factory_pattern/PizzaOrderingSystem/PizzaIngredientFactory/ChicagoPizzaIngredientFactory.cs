namespace PizzaOrderingSystem.PizzaIngredientFactory;

using PizzaOrderingSystem.PizzaIngredientFactory.Ingredient;

public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
	public Dough CreateDough()
    {
        return new ThickCrustDough();
    }
	public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }
	public Veggie[] CreateVeggies()
    {
        Veggie[] veggies  = new Veggie[]{ new BlackOlives(), new Onion(), new Mushroom() };
        return veggies;
    }
	public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }
	public Clams CreateClam()
    {
        return new FrozenCalms();
    }
}