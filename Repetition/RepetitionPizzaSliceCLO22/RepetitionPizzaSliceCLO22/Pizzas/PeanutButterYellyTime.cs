namespace RepetitionPizzaSliceCLO22.Models
{
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models.Ingredients;

    public class PeanutButterYellyTime : Pizza
    {
        public PeanutButterYellyTime()
        {
            Ingredients = new List<IIngredients>
            {
                new PeanutButter(), new Yelly()
            };
        }
    }
}
