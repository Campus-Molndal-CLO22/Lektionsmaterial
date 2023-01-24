// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Pizza!");

IPizza pizza = new PizzaFactory().CreatePizza("Margarita")!;
Console.WriteLine(pizza.Name);
Console.WriteLine(pizza.Dough);
Console.WriteLine(pizza.Sauce);
Console.WriteLine(string.Join(", ", pizza.Toppings));


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

public class PizzaFactory
{
    public IPizza? CreatePizza(string type, bool isGlutenFree=false)
    {
        IPizza? pizza = null;
        switch (type)
        {
            case "Margarita":
                pizza = new Pizza()
                {
                    Name = "Margarita",
                    Dough = "Thin",
                    Sauce = "Tomato",
                    Toppings = new List<string>() { "Cheese", "Tomato" },
                    Price = 10,
                    IsGlutenFree= isGlutenFree
                };
                break;
            case "Pepperoni":
                pizza = new Pizza()
                {
                    Name = "Pepperoni",
                    Dough = "Thin",
                    Sauce = "Tomato",
                    Toppings = new List<string>() { "Cheese", "Tomato", "Pepperoni" },
                    Price = 12,
                    IsGlutenFree = isGlutenFree
                };
                break;
            case "Hawaiian":
                pizza = new Pizza()
                {
                    Name = "Hawaiian",
                    Dough = "Thin",
                    Sauce = "Tomato",
                    Toppings = new List<string>() { "Cheese", "Tomato", "Ham", "Pineapple" },
                    Price = 12,
                    IsGlutenFree = isGlutenFree
                };
                break;
        default:
                return null;
    }
        return pizza;
    }
}