namespace RepetitionPizzaSliceCLO22.Models
{
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models.Ingredients;

    public class Pizza : IPizza
    {
        public List<IIngredients> Ingredients { get; set; }
        public float Price { get; set; }
        public Pizza()
        {
            Ingredients = new List<IIngredients>
            {
                new Mozzarella(), new SmashedTomato(), new Ham()
            };
            Price = 75f + Ingredients.Sum(x => x.Price);
        }
    }
}
