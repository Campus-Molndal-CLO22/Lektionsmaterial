﻿namespace RepetitionPizzaSliceCLO22.Models
{
    using System.Collections.Generic;
    using RepetitionPizzaSliceCLO22.Interfaces;
    using RepetitionPizzaSliceCLO22.Models.Ingredients;

    public class Margherita : Pizza
    {
        public Margherita()
        {
            Ingredients = new List<IIngredients>
            {
                new Gouda(), new SmashedTomato()
            };
        }
    }
}
