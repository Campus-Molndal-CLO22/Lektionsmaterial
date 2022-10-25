namespace RepetitionPizzaSliceCLO22.Models
{
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models.Ingredients;

    public class MalmöSpecial : Pizza
    {
        public MalmöSpecial()
        {
            Ingredients = new List<IIngredients>
            {
                new Gouda(), new SmashedTomato(), new Rat()
            };
        }
    }
}
