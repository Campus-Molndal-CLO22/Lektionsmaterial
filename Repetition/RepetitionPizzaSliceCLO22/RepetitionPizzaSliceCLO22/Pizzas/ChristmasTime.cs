namespace RepetitionPizzaSliceCLO22.Models
{
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models.Ingredients;

    public class ChristmasTime : Pizza
    {
        public ChristmasTime()
        {
            Ingredients = new List<IIngredients>
            {
                new Mozzarella(), new Apple(), new Cinnamon(), new Turkey()
            };
        }
    }
}
