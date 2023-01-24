// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, PizzaBuilder!");

var pizza = new BuildPizza()
    .WithName("Margarita")
    .WithDough("Thin")
    .WithSauce("Tomato")
    .WithToppings("Cheese")
    .WithToppings("Tomato")
    .WithPrice(5)
    .WithGlutenFree(true)
    .Build();

Console.WriteLine(pizza.Name);
Console.WriteLine(pizza.Dough);
Console.WriteLine(pizza.Sauce);
Console.WriteLine(string.Join(", ", pizza.Toppings));
Console.WriteLine(pizza.Price);
Console.WriteLine(pizza.IsGlutenFree);

public interface IPizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; }
    public int Price { get; set; }
}

public class Pizza : IPizza
{
    public string Name { get; set; } = "";
    public string Dough { get; set; } = "";
    public string Sauce { get; set; } = "";
    public List<string> Toppings { get; set; } = new();
    public int Price { get; set; } = 0;
    public bool IsGlutenFree { get; set; }
}

public class BuildPizza
{
    Pizza tmp = new();
    public BuildPizza WithName(string name)
    {
        tmp.Name = name;
        return this;
    }

    public BuildPizza WithDough(string dough)
    {
        tmp.Dough = dough;
        return this;
    }

    public BuildPizza WithSauce(string sauce)
    {
        tmp.Sauce = sauce;
        return this;
    }

    public BuildPizza WithToppings(List<string> toppings)
    {
        tmp.Toppings = toppings;
        return this;
    }

    public BuildPizza WithToppings(string topping)
    {
        if (tmp.Toppings == null)
            tmp.Toppings = new();
        tmp.Toppings.Add(topping);
        return this;
    }

    public BuildPizza WithPrice(int price)
    {
        tmp.Price = price;
        return this;
    }

    public BuildPizza WithGlutenFree(bool isGlutenFree)
    {
        tmp.IsGlutenFree = isGlutenFree;
        return this;
    }

    public Pizza Build()
    {
        var newPizza = new Pizza();
        newPizza.Name = tmp.Name;
        newPizza.Dough = tmp.Dough;
        newPizza.Sauce = tmp.Sauce;
        newPizza.Toppings = tmp.Toppings;
        newPizza.Price = tmp.Price;
        newPizza.IsGlutenFree = tmp.IsGlutenFree;
        if (newPizza.IsGlutenFree) newPizza.Price += 2;
        return newPizza;
    }
}