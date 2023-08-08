
using Cafe.Beverage;
using Cafe.Condiment;

Beverage beverage1 = new DarkRoast();
beverage1 = new Milk(beverage1);
beverage1 = new Whip(beverage1);

Console.WriteLine($"Description : {beverage1.GetDescription()}");
Console.WriteLine($"cost : {beverage1.GetCost()}");

Beverage beverage2 = new Decafe();
beverage2.Size = BeverageSize.Venti;
beverage2 = new Soy(beverage2);

Console.WriteLine($"Description : {beverage2.GetDescription()}");
Console.WriteLine($"cost : {beverage2.GetCost()}");