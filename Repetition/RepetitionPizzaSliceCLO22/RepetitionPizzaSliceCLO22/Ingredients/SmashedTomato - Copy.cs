﻿namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class SmashedTomato : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public SmashedTomato()
        {
            Name = "SmashedTomato";
            AmountInGram = 150;
            Price = 5;
        }
    }
}
