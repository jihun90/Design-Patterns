using System.Text;
using PizzaOrderingSystem.PizzaIngredientFactory.Ingredient;

namespace PizzaOrderingSystem.Pizza;

public abstract class Pizza
{
    protected string name = ""; 

    protected Dough? dough;
    protected Sauce? sauce;
    protected Veggie[]? veggies;
    protected Cheese? cheese;
    protected Clams? clam;

    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("175도에서 25분간 굽기");
    }
    
    public void Cut()
    {
        Console.WriteLine("피자를 사선으로 자르기");
    }

    public void Box()
    {
        Console.WriteLine("상자에 피자담기");
    }

    public override string ToString()
    {
        StringBuilder display = new StringBuilder();
        display.AppendLine($"name : {name}");
        
        if (dough != null)
        {
            display.AppendLine($"dough : {dough}");
        }
        
        if (sauce != null)
        {
            display.AppendLine($"sauce : {sauce}");
        }

        if (cheese != null)
        {
            display.AppendLine($"cheese : {cheese}");
        }


        if (clam != null)
        {
            display.AppendLine($"clams : {clam}");
        }

        if(veggies != null)
        {
            display.Append("veggies : ");

            string veggiesString = "";
            foreach (Veggie v in veggies)
            {
                veggiesString += v.ToString() + ", ";
            }
            display.Append(veggiesString);
        }
        
        return display.ToString();
    }
}