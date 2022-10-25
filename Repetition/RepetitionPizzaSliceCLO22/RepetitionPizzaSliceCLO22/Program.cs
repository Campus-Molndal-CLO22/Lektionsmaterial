// See https://aka.ms/new-console-template for more information
using RepetitionPizzaSliceCLO22;
using RepetitionPizzaSliceCLO22.Extensions;

Console.WriteLine("Pizzaria Marcus di Magsjuka!");
Console.WriteLine();
var baker = new Baker();
baker.Menu();
int input = Console.ReadLine().ToInt();
var pizza = baker.MakePizza(input);
Console.WriteLine("You ordered a " + pizza.GetType().Name);
Console.WriteLine("It contains:");
foreach (var ingredient in pizza.Ingredients)
{
    Console.WriteLine(ingredient.Name);
}