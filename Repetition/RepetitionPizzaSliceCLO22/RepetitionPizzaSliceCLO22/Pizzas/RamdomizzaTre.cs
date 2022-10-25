namespace RepetitionPizzaSliceCLO22.Models
{
    using System;
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;

    /// <summary>
    /// Defines the <see cref="RandomizzaTre" />.
    /// </summary>
    public class RamdomizzaTre : Pizza, IPizza
    {
        protected int amountOfIngredients = 3;
        public RamdomizzaTre()
        {
            amountOfIngredients = 3;
            AddIngredients();
        }
        public RamdomizzaTre(int amountOfIngredients = 3)
        {
            this.amountOfIngredients = amountOfIngredients;
            AddIngredients();
        }

        private void AddIngredients()
        {
            var ingredients = GetIngredients();
            var random = new Random();
            Ingredients = new List<IIngredients>();
            for (int i = 0; i < amountOfIngredients; i++)
            {
                int index = random.Next(0, ingredients.Count);
                Ingredients.Add(ingredients[index]);
                ingredients.RemoveAt(index); // Make sure no ingredient is added twice
            }
        }

        private List<IIngredients?> GetIngredients()
        {
            // Code snatched from : https://garywoodfine.com/get-c-classes-implementing-interface/
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                  .Where(x => typeof(IIngredients).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                  .Select(x => Activator.CreateInstance(x) as IIngredients).ToList();
        }
    }
}
