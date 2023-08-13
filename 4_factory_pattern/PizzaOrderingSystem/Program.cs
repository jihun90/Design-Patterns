using PizzaOrderingSystem.PizzaStore;
using PizzaOrderingSystem.Pizza;

PizzaStore NYStore = new NewYorkPizzaStore();
Pizza pizza1 =  NYStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine(pizza1.ToString());


Console.WriteLine("");
Console.WriteLine("NEXT");
Console.WriteLine("");

PizzaStore ChicagoStore = new ChicacoPizzaStore();
Pizza pizza2 =  ChicagoStore.OrderPizza(PizzaType.Veggie);
Console.WriteLine(pizza2.ToString());