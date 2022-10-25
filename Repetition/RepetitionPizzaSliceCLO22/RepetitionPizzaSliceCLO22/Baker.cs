namespace RepetitionPizzaSliceCLO22
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models;

    public class Baker
    {
        List<IPizza> pizzas;
        public Baker()
        {
            pizzas = ListPizzas();
        }
        public IPizza MakePizza(int pizza)
        {
            pizza--;
            return pizzas[pizza] ?? new Pizza();
        }

        public void Menu()
        {
            for (int row = 0; row < pizzas.Count; row++)
            {
                Console.WriteLine((row + 1).ToString(" 0") + " - " + pizzas[row].GetType().Name);
                Console.Write("   ");
                var lastPos = 0;
                foreach (var ingredient in pizzas[row].Ingredients)
                {
                    Console.Write(ingredient.Name + ", ");
                    if (Console.CursorLeft > 50)
                    {
                        Console.WriteLine("");
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("deg.");
            }
        }

        private List<IPizza?> ListPizzas()
        {
            // Code inspired from: https://garywoodfine.com/get-c-classes-implementing-interface/
            return AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IPizza).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (IPizza?)Activator.CreateInstance(x))
                .ToList();
        }
    }
}




